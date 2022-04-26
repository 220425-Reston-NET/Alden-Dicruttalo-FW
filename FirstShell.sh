# this is a comment
#It is like putting a sticky note to your code to give a more meaningfull
# message
#Echo is a way for us to give feedback to...
echo "This is your first shell script!"

#variables
msg="Hello World Variable"
echo $msg # $ syntax signifyes that we are refrencing a variable

# Control Flow
#  They are a way to tell the program to run multiple lines of code multiple 
# times

# if statements
#

ten=10
five=5
thirteen=13

echo "===first If==="
if [ "$ten" -ge "$five" ]
then
echo "Greater!"
echo "$ten > $five"
fi
echo "==="

if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then
echo "lesser!"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"

elif [ "$five" -ge "$thirteen" ]
then
echo "greater!"
echo "$five < $thirteen"
else
echo "Nothing Matches"
fi

#loop Statements
# A way to repeat multiple lines of code x amount of times you want

# for Loop Statement
# useful if you know how many times you need to execute those lines
# of code ----- Will repeat X amount of times

echo "===For Loops==="
echo "===First Loop==="
for number in 2 4 6 8 10
do
echo "Hello $number"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

echo "===While Loops==="
# While loop statement
# Useful if you don't know how many times you need to execute those
# those lines of code

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) # $((mathmatical operation)) is how we can do math
echo "$five"
done

# Input and Output
# We can ask for imput from the user that is using the shell scripting
# and we can output some sort of response

echo "What is your name?"
read name # Read [variable] will store the user input in that varianle

echo "Hello $name, Welcome to programming!"

# making a shell menu
clear # clear command will clear all the text in the terminal
repeat="true"

while [ "$repeat" == "true" ]
do
echo "welcome to shell Scripting!"
echo "What do you want to do today?"
echo "Enter 1 for adding two numbers."
echo "enter 2 to exit"
read answer

if [ "$answer" == "1" ]
then
	echo "Give me number 1"
	read num1
	echo "Give me number 2"
	read num2
	echo "The sum is $num1 + $num2"
	echo "The sum is $(($num1 +$num2))"
elif [ "$answer" == "2" ]
then
	repeat="false"
fi
elif
then
	echo "Please enter a correct option"
fi
done
