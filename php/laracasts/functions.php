<?php
function dd($list){
    echo '<pre>';
    die(var_dump($list));
    echo '</pre>';
}

function checkAge($age){
    if ($age >= 19){
        return true;
    } else {
        return false;
    }
}

function numChecker(Array $numList,int $num){
    $i = 0; // keep track of array index
    foreach ($numList as $nums) {
        if ($nums[0] <= $num && $nums[1] >= $num) { // compare each number per specifications
            return $i;
        }
        $i++;
    }
    return 'Not Found in list';
}
