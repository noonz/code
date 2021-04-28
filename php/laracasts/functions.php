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
