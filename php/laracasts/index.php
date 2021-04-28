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

if (checkAge(21)){
    echo "Access";
} else {
    echo "Denied";
}

require 'index.view.php';
