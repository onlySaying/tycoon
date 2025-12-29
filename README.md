# tycoonDemo
demo playingoptions
![1](https://user-images.githubusercontent.com/48788534/232291047-e26911a8-c079-40eb-9e17-de954e8a2850.png)
![2](https://user-images.githubusercontent.com/48788534/232291034-e6f23bb4-c75e-4ef9-89f8-f7dcfb839f17.png)
![3](https://user-images.githubusercontent.com/48788534/232291040-b5f5b071-df08-4b4e-885d-a45054397557.png)
![4](https://user-images.githubusercontent.com/48788534/232291043-a6e67a54-e46c-4377-9c60-011aa9a99be8.png)
![5](https://user-images.githubusercontent.com/48788534/232291044-c296fc19-4a86-457a-9c70-542da69b31e4.png)
![tycoon 2023-04-16 18-42-10](https://user-images.githubusercontent.com/48788534/232291239-dd7006b8-c971-475e-8074-a13988c666ac.gif)
![tycoon 2023-04-16 18-39-30](https://user-images.githubusercontent.com/48788534/232291246-c8db760a-ac00-49a7-b291-bedef6884266.gif)

# Hamburger Tycoon

## 1. 프로젝트 개요
유니티 엔진으로 제작한 햄버거 타이쿤 게임입니다.
엔진 기능에 의존하지 않고, 게임의 핵심 로직을 직접 설계하고 구현하는 것을 목표로 했습니다.

## 2. 개발 동기
에셋과 컴포넌트를 활용한 빠른 구현 과정에서,
내부 동작 원리를 이해하지 못한 채 기능을 조립하는 한계를 느꼈습니다.
이에 자료구조와 알고리즘을 실제 게임 로직에 적용해보고자 본 프로젝트를 진행했습니다.

## 3. 핵심 시스템 설계
### (1) 햄버거 조립 및 레시피 검증
- Stack 자료구조를 사용해 재료를 LIFO 구조로 관리
- 플레이어 입력과 레시피를 비교해 조립 성공 여부 판단

### (2) 식재료 데이터 관리
- HashMap을 활용해 재료 데이터를 관리
- 재료 ID 기반 조회로 반복 탐색 비용 감소

## 4. 기술적 포인트
- 엔진 제공 기능을 그대로 사용하지 않고,
  로직을 직접 구현하며 자료구조 선택의 이유를 고민
- 기능 구현보다 구조적 설계와 설명 가능성을 우선

## 5. 회고
엔진의 편의성 뒤에 숨은 로직을 직접 설계하며,
'동작하는 코드'와 '설명 가능한 코드'의 차이를 체감했습니다.
