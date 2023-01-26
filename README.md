# SAM Software Automatic Mouth

## What is SAM?

This is a C# port of the Text-To-Speech (TTS) software
SAM (Software Automatic Mouth) for the Commodore C64 published in the
year 1982 by Don't Ask Software (now SoftVoice, Inc.).

It is based on the adaption to C by
[Stefan Macke](https://github.com/s-macke/SAM)
and the refactorings by 
[Vidar Hokstad](https://github.com/vidarh/SAM) and
[8BitPimp](https://github.com/8BitPimp/SAM), further rewritten in JavaScript by [discordier](https://github.com/discordier/sam).

It includes a Text-To-Phoneme converter called reciter and a
Phoneme-To-Speech routine for the final output.

For further details, refer to
[retrobits.net](http://www.retrobits.net/atari/sam.shtml)

Some analytics of S.A.M. in general can be found in Artyom Skrobov's
(@tyomitch) blog who also provided pretty insightful PRs.
Visit his blog https://habr.com/ru/post/500764/ (in Russian)
or the google translated version
[here](https://habr-com.translate.goog/ru/post/500764/?_x_tr_sl=auto&_x_tr_tl=en).

## Usage

None yet, this is WIP.

### Typical voice values

```
DESCRIPTION          SPEED     PITCH     THROAT    MOUTH
Elf                   72        64        110       160
Little Robot          92        60        190       190
Stuffy Guy            82        72        110       105
Little Old Lady       82        32        145       145
Extra-Terrestrial    100        64        150       200
SAM                   72        64        128       128
```

## Original docs

I have bundled a copy of the original manual in this repository, see
the [manual](docs/manual.md) file in the [docs](docs) directory.

## License

The software is a reverse-engineered version of a commercial software
published more than 30 years ago. The current copyright holder is 
SoftVoice, Inc. (www.text2speech.com)

Any attempt to contact the company failed. The website was last
updated in the year 2009. The status of the original
software can therefore best described as abandonware
(http://en.wikipedia.org/wiki/Abandonware)

As long this is the case I cannot put my code under any specific open
source software license. Use it at your own risk.

## Contact

If you have questions don't hesitate to ask me. If you discovered some
new knowledge about the code please file an issue.
