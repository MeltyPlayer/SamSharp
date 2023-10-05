using System;

namespace SamSharp.Renderer
{
    public class OutputBuffer
    {
        // TODO: Can allocate HUGE amounts of memory with long inputs, use streams instead?
        private byte[] buffer;

        private int bufferPos = 0;
        private int oldTimeTableIndex = 0;

        public OutputBuffer(int bufferSize)
        {
            buffer = new byte[bufferSize];
        }

        public void Write(int index, int a)
        {
            byte scaled = (byte) (((a & 15) * 16) & 0xFF);
            Ary(index, new [] { scaled, scaled, scaled, scaled, scaled });
        }

        // Timetable for more accurate C64 simulation
        private readonly byte[] timetable =
        {
          162, 167, 167, 127, 128, // Formants synth
          226, 60, 60, 0, 0, // Unvoiced sample 0
          225, 60, 59, 0, 0, // Unvoiced sample 1
          200, 0, 0, 54, 55, // Voiced sample 0
          199, 0, 0, 54, 54, // Voiced sample 1
        };

        public void Ary(int index, ReadOnlySpan<byte> array)
        {
            bufferPos += timetable[5 * oldTimeTableIndex + index];

            if (bufferPos / 50 > buffer.Length)
                throw new Exception($"Buffer overflow, want {bufferPos / 50} but buffer size is {buffer.Length}");

            oldTimeTableIndex = index;

            // Write a little bit in advance
            array.CopyTo(buffer.AsSpan(bufferPos / 50));
        }

        public byte[] Get()
        {
            return buffer.AsSpan(0, bufferPos / 50).ToArray();
        }
  }
}