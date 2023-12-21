# Week 2
## 별로 다이아몬드를!
C# 프로젝트를 생성

### 요구 사항
- 출력을 보고 규칙을 유추한 뒤에 별을 찍어보자.
### Input
- N(1 ~ 100)
### OutPut
- 첫째 줄부터 2×N-1번째 줄까지 차례대로 별을 출력

![Star4](https://github.com/heewhy/Edu_CSharp/assets/55123531/17911ee3-27d0-4ca2-9710-bd51f11884a0)
![Star7](https://github.com/heewhy/Edu_CSharp/assets/55123531/e6b780b5-fc4b-4936-bd85-3c7fcfa4b96a)
![Star10](https://github.com/heewhy/Edu_CSharp/assets/55123531/5eeed974-fc13-4212-bafb-57ac15f32882)

## 숫자 야구!
C# 프로젝트를 생성

### 요구 사항
- 숫자 야구는 숫자 3개와 위치를 맞추는 게임이다.
- Game Master(이하 GM)이 랜덤으로 숫자 3개를 정한다.
- 숫자를 정할때에 숫자는 중복이 될 수 없다.
- 숫자에 0이 포함될 수 없다.
- Player가 숫자 3개를 정한다.
- Player의 입력에 숫자 외에 다른 것이 올 수 없다.
- Player의 입력에 3자리 초과, 미만의 숫자가 올 수 없다.
- Player의 숫자 또한 중복이 될 수 없다.
- Player의 숫자 또한 0이 포함될 수 없다.
- 숫자를 맞추고 위치가 맞으면 1 Strike
- 숫자는 맞췄으나 위치가 맞지않으면 1 Ball
- 숫자가 없다면 아무일도 일어나지 않는다.
- Player가 3 Strike 될 때까지 게임은 계속 반복된다.
- Player가 3 Strike 된 시점에서 게임을 종료한다.

### Input
- N (3자리 숫자)
- 0은 포함되지 않는 1 ~ 9 까지의 자리를 기준으로 한다.
- 중복된 숫자 혹은 범위가 벗어난 숫자가 입력되면 "유효한 숫자를 입력해주세요."를 출력하고 다시 입력받는다.
### OutPut
- Strike, Ball, 게임이 종료되었습니다.
- EX) GM 123
- EX) player 456 x
- EX) player 416 1 Ball
- EX) player 156 1 Strike
- EX) player 152 1 Strike 1 Ball
- EX) player 312 3 Ball
- EX) player 123 3 Strike 게임 종료

![numbaseball](https://github.com/heewhy/Edu_CSharp/assets/55123531/269ed601-fd61-4597-be58-33976ce61908)
