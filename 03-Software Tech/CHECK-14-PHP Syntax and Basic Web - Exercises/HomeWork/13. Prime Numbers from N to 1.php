<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>



    <?php
    if (isset($_GET['num'])){
        $num = intval($_GET['num']);
        $isPrime = false;

        for ($i=$num;$i>=2; $i--){

            for ($y=2; $y<=$i-1; $y++) {
                if ($i % $y == 0) {
                    $isPrime = false;
                    break;
                }
                $isPrime = true;
            }


         if ($isPrime){
                echo "$i ";
         }
        }
    }
    ?>
	<!--Write your PHP Script here-->
</body>
</html>