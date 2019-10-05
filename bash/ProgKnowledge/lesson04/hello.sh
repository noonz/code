#! /bin/bash

# Pass arguments to a bash-script (index 0 starts at file)
echo $0 $1 $2 $3 '> echo $0 $1 $2 $3'

# Pass arguments into an array (index 0 starts with first arg typed)
args=("$@")

echo ${args[0]} ${args[1]} ${args[2]} ${args[3]}

# prints the args array created
echo $@

# prints number of arguments passed
echo $#
