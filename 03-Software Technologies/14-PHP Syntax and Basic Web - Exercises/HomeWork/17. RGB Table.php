<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
    $step = 51;
    for ($i = 1; $i <= 5; $i++) {
        echo "<tr>";


        for ($y = 1; $y <= 3; $y++) {
            if ($y == 1) {
                echo "<td style='background-color: RGB($step, 0, 0)'>";
            }
            else if ($y == 2) {
                echo "<td style='background-color: RGB(0, $step, 0)'>";
            }
            else if ($y == 3) {
                echo "<td style='background-color: RGB(0, 0, $step)'>";
            }
            echo "</td>";

        }
        $step+=51;
        echo "<tr>";

    }
    ?>

</table>
</body>
</html>