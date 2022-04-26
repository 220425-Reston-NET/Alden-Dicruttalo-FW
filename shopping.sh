# while look to prompt the user if they want to exit

running="true"
while [ "$running" == "true" ]
do

echo "Welcome to our grocery store"

echo "Press the crrosponding number to select an item"
echo "Press 0 to exit"
echo "1 Beef"
echo "2 Chicken"
echo "3 Milk"
echo "4 Eggs"
echo "5 Juice"
echo " === "

read selection

if [ "$selection" == "0" ]
then
running="false"
fi

if [ "$selection" == "1" ]
then
echo "3.99 dollars"
fi

if [ "$selection" == "2" ]
then
echo "4.99 dollars"
fi

if [ "$selection" == "3" ]
then
echo "5.99 dollars"
fi


if [ "$selection" == "4" ]
then
echo "6.99 dollars"
fi


if [ "$selection" == "5" ]
then
echo "7.99 dollars"
fi


done








