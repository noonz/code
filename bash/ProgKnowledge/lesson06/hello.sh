#! /bin/bash

# # Pass arguments to a bash-script (index 0 starts at file)
# echo $0 $1 $2 $3 '> echo $0 $1 $2 $3'

# # Pass arguments into an array (index 0 starts with first arg typed)
# args=("$@")

# echo ${args[0]} ${args[1]} ${args[2]} ${args[3]}

# # prints the args array created
# echo $@

# # prints number of arguments passed
# echo $#



# IF STATEMENTS (if then, if then else, if elif else)
# if [condition]
# then
#     statement
# fi

# count=10
# if [ $count -ne 10 ]
# then
#     echo 'if condition is true'
# elif [[ $count -eq 10 ]]
# then
#     echo 'elif condition is true'
# else
#     echo 'else condition is false'
# fi



# FILE TEST OPERATORS

# \c keeps cursor on the same line, requires -e flag
echo -e 'Enter name of file: \c'
read file_name

# -e flag tests if file exists or not
# -f file exists, and regular file or not
# -d directory exists
# -b blob special file (binary, music files, pictures, videos, etc)
# -c character special file (text)
# -s checks if file is empty or not
# -r checks if file has read permission
# -w checks write permission
# -x checks execute permission
if [[ -f $file_name ]]; then
    #statements
    echo "$file_name exists"
else
    echo "$file_name doesn't exists"
fi
