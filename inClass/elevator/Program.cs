// See https://aka.ms/new-console-template for more information
VIPelevator vip = new VIPelevator("vip",31);
Elevator one = new Elevator("one",30);
Elevator two = new Elevator("two",30);

one.DisplayFloor();
one.OpenDoor();
one.CloseDoor();
one.ListFloors();
one.MoveToFloor(5);
one.DisplayFloor();
one.CallElevator(30);
one.DisplayFloor();

two.DisplayFloor();
two.OpenDoor();
two.CloseDoor();
two.ListFloors();
two.MoveToFloor(7);
two.DisplayFloor();
two.CallElevator(20);
two.DisplayFloor();

vip.VerifyCode("121");
vip.VerifyCode("1234");
vip.DisplayFloor();
vip.OpenDoor();
vip.CloseDoor();
vip.ListFloors();
vip.MoveToFloor(7);
vip.DisplayFloor();
vip.CallElevator(20);
vip.DisplayFloor();