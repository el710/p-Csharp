# Good style coding
`
Design guidlines: https://docs.microsoft.com/en-us/dotnet/standart/design-guidelines
`
## Naming
- Name of variable must be readed
>~~int a;~~
>`int userNumber;`

- Name of method must tell what it does
>  ~~void F();~~
>`void GetIntegerNumber();`

- Do not use abbreviations except common used
- Do not reduct if not nessesary
>~~int SPDCnt;~~
>`int RingToUSA`

>~~InitWin~~
>`InitWindow`

>~~SendPM(int i, string t)~~
>`SendPrivateMessage(int id, string text)`

>~~ScrollableX~~
>`CanScrollHorizontally`

- Do not use name like reserved names of programming language
>~~string class = "1B"~~
>`string classRoom = "1B"`

- Do not use '_' and '-' in names
>~~int my_number~~

- Use easy reading way
>~~AlignmentHorisontal~~
>`HorisontalAlignment`

## Do not use profanity
>~~f.ck~~

## Do not write long string line
>~~int result = (1 + 2) - (3 + 4 ) / (15 * 12) / (...) ...~~


- name of variable start from lowercase: `userNumber`
- name of method start from uppercase: `GetUserNumber()`
- add variable in place where you start to use it
>int i;
>~~some code~~
>i = 123;

