# Week 3
## 팩토리얼
C# 프로젝트를 생성, 재귀 함수

### 요구 사항
- n!은 정수 n에 대한 팩토리얼 수를 나타내는데, 이는 1부터 n까지의 모든 정수의 곱을 의미한다.
- 정수를 입력받고 정수!를 출력하는 프로그램을 만들어보자.
### Input
- N(1 ~ 10)
### OutPut
- N!

![Factorial_5](https://github.com/heewhy/Edu_CSharp/assets/55123531/068f374d-c9d6-4fc6-9932-518418a3919e)
![Factorial_8](https://github.com/heewhy/Edu_CSharp/assets/55123531/53316430-57ff-4194-b387-550d8f6bf4a8)
![Factorial_10](https://github.com/heewhy/Edu_CSharp/assets/55123531/55cdd313-4145-4749-8994-b9a1f586daa9)

## 피보나치 수열
C# 프로젝트를 생성, 재귀 함수

![Fibonacchi](https://github.com/heewhy/Edu_CSharp/assets/55123531/fd0c82e7-9753-41c1-bd5c-7e2375b19ea8)

### 요구 사항
- 제 1항과 제 2항을 1이라 하고, 제 3항부터는 앞의 두 항의 합을 취하는 수열을 피보나치(fibonacci) 수열이라고 한다. 
- 예를 들어 제 3항은 2이며, 제 4항은 3이다.
- 피보나치 수열의 a번째 항부터 b번째 항까지의 합을 구하는 프로그램을 만들어보자.
### Input
- a b (1 ~ 30)
### OutPut
- 각 항의 덧셈

![Fibonacchi34](https://github.com/heewhy/Edu_CSharp/assets/55123531/450870c4-e84b-4280-b254-74730eeb5e90)
![Fibonacchi45](https://github.com/heewhy/Edu_CSharp/assets/55123531/ecf8bc20-74d0-45c9-af00-80841b30b625)
![Fibonacchi56](https://github.com/heewhy/Edu_CSharp/assets/55123531/4ef0bc11-7cee-4a9f-bd23-303e762a6546)

## 하노이탑
C# 프로젝트를 생성, 재귀 함수

![hanoi](https://github.com/heewhy/Edu_CSharp/assets/55123531/32ae2201-5f7d-4196-93cb-59cf23d8bfe5)

### 요구 사항
- 세 개의 장대가 있고 첫 번째 장대에는 반경이 서로 다른 5개의 원판이 쌓여 있다.
- 각 원판은 반경이 큰 순서대로 쌓여있다.
- 이제 수도승들이 다음 규칙에 따라 첫 번째 장대에서 세 번째 장대로 옮기려 한다.
1. 한 번에 한 개의 원판만을 다른 탑으로 옮길 수 있다.
2. 쌓아 놓은 원판은 항상 위의 것이 아래의 것보다 작아야 한다.
- 이 작업을 수행하는 동안 탑의 상황을 출력하는 프로그램을 만들어보자.

### Input
- X
### OutPut
- 이동 상황
- 총 옮긴 횟수

![dohanoi](https://github.com/heewhy/Edu_CSharp/assets/55123531/359fbae3-3b17-49fa-b409-83f26f69e720)

## 달팽이 찍기!
C# 프로젝트를 생성

### 요구 사항
- 정수가 주어지면 N x N 의 Map이 생성이 된다.
- 달팽이는 (0, 0)에서 출발하여 빙글빙글 돌며 모든 경로를 지난다.
- 달팽이는 오른쪽, 아래, 왼쪽, 위 방향의 우선순위로 이동한다.
- 달팽이가 이동하는 순서를 Map에 출력하는 프로그램을 만들어보자.
### Input
- N (1 ~ 50)
### OutPut
- Map

![Snail](https://github.com/heewhy/Edu_CSharp/assets/55123531/3227d567-9ed9-4305-8e09-d7c29de98a9e)

## 다리 놓기
C# 프로젝트를 생성

### 요구 사항
- 도시를 동쪽과 서쪽으로 나누는 큰 일직선 모양의 강이 흐르고 있다. 
- 강 주변에서 다리를 짓기에 적합한 곳을 사이트라고 한다.
- 강의 서쪽에는 N개의 사이트가 있고 동쪽에는 M개의 사이트가 있다. (N ≤ M)
- 서쪽의 사이트와 동쪽의 사이트를 다리로 연결한다.
- 다리를 최대한 많이 지으려고 하기 때문에 서쪽의 사이트 개수만큼 (N개) 다리를 지으려고 한다.
- 다리끼리는 서로 겹쳐질 수 없다.
- 다리를 지을 수 있는 경우의 수를 구하는 프로그램을 만들어보자.
### Input
- 0 < N ≤ M < 30
### OutPut
- 경우의 수

![Bridge](https://github.com/heewhy/Edu_CSharp/assets/55123531/43d3f431-81d0-4b24-ab10-0a5a3b86e4b6)

## 색종이
C# 프로젝트를 생성

### 요구 사항
- 가로, 세로의 크기가 각각 100인 정사각형 모양의 흰색 도화지가 있다.
- 도화지 위에 가로, 세로의 크기가 각각 10인 정사각형 모양의 검은색 색종이를 색종이의 변과 도화지의 변이 평행하도록 붙인다. 
- 이러한 방식으로 색종이를 한 장 또는 여러 장 붙인다.
- 색종이가 붙은 검은 영역의 넓이를 구하는 프로그램을 만들어보자.
### Input
- 3
- 3 7
- 15 7
- 5 2
### OutPut
- 넓이(260)

![CololrPaper](https://github.com/heewhy/Edu_CSharp/assets/55123531/4d3270a8-4552-497c-b1ce-f94077a2e98d)

## 서점 관리 프로그램
C# 프로젝트를 생성

### 요구 사항
- 서점에서 재고 관리를 위한 프로그램을 만들어보자. (List, ArrayList 금지)
- 좋은 아이디어로 추가할 수 있는 기능이 있다면 추가해보자.
- Book 클래스
    - 상품 공통 정보를 담는 클래스
- Book을 상속받은 ComicBook 과 Novel 클래스
- BookManger 클래스
    - 책 정보를 객체 배열을 활용하여 저장
    - 책 정보 전체를 검색하는 기능
    - 책 번호로 책을 검색하는 기능
    - 책명으로 책을 검색하는 기능(부분검색 가능)
    - ComicBook 에서만 검색하는 기능
    - ComicBook 전체를 검색하는 기능
    - Novel 에서만 검색하는 기능
    - Novel 전체를 검색하는 기능
    - 책 번호로 상품을 삭제하는 기능
    - 전체 재고 상품 금액을 구하는 기능
- BookTest 클래스
    - 모든 기능의 테스트를 위한 Dummy Data 입력하는 기능
    - 모든 기능을 테스트할 수 있는 기능

