<?php

$person = [
    'age' => 30,
    'hair' => 'brown',
    'career' => 'software developer'
];

$person['name'] = 'Dave';

die(var_dump($person));

require 'index.view.php';
