<?php

require 'functions.php';

// $task = [
//     'title' => 'Finish Homework',
//     'due' => 'today',
//     'assigned_to' => 'Dave',
//     'completed' => true
// ];

// $animals = ['dog','cat','horse','lion'];
// dd($animals);

// if (checkAge(21)){
//     echo "Access";
// } else {
//     echo "Denied";
// }

$numberList = [
    [0,10],
    [11,50],
    [51,100],
    [100,200],
    [200,500]
];

echo numChecker($numberList, 550);


require 'index.view.php';
