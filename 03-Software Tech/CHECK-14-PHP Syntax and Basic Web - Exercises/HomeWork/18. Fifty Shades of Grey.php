<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style> 
</head>
<body>


<?php
$step = 0;
for ($i = 1; $i <= 5; $i++) {


    for ($y = 1; $y <= 10; $y++) {
        echo "<div style='background-color: RGB($step, $step, $step')>";

        echo "";


        echo "</div>";
        $step+=5;

    }
    echo"<br>";
    $step+=1;
}
?>

</body>
</html>