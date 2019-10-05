#! /bin/bash
# # System Variables
# echo 'bash location:' $BASH
# echo 'bash version:' $BASH_VERSION
# echo 'home directory:' $HOME
# echo 'present working directory:' $PWD

# # Create a variable, DONT START WITH NUMBER
# name=Dave
# echo Your name: $name

# Read User Input
echo 'Enter word: '
read name
echo "You typed : $name"

# Read multiple values
# echo 'Enter more words: '
# read word1 word2 word3
# echo "Your words: $word1, $word2, $word3"

# read input from a single line
read -p 'username: ' user_var
# add the -s (silence) flag for passwords
read -sp 'password: ' user_pass
echo
echo "username: $user_var"
echo "password: $user_pass"

# store values in an array
echo "Enter names: "
read -a names
echo "Names: ${names[0]}, ${names[1]}"

# reading input without storing in a variable
echo "last one: "
read
echo "word: $REPLY"
