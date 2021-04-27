<!DOCTYPE html>
<html lang="en" dir="ltr">
    <head>
        <meta charset="utf-8">
        <title>Document</title>

        <style>
            header {
                background: #e3e3e3;
                padding: 2em;
                text-align: center;
            }
        </style>

    </head>
    <body>
        <ul>
            <?php foreach ($person as $feature => $val) : ?>
                <li><strong><?= $feature ?></strong> <?= $val ?></li>
            <?php endforeach; ?>
        </ul>

    </body>
</html>
