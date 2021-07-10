Cinemachine을 이용한 커스텀 달리 시스템입니다.

<사용방법>
Timeline에서 Target은 Signal을 받아 TargetMove.cs의 TargetToMove 함수를 실행합니다.
TargetToPos의 파라미터로 Pos션이 들어가 있고, Target이 각각의 Pos로 이동하면 Cinemachine이 Target을 따라갑니다.
이런 방식으로 새로운 움직임을 만들고 싶다면, Timeline에 Pos를 만들어 Target이 이동하게 하고, 같은 시간에 cinemachine 카메라를 추가하여 어떤 방식으로 따라갈지 정해줍니다. 
