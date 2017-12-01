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
        $oldNumber=1;
        $midNumber=1;
        $newNumber=2;
        $result = 2;

        echo "$oldNumber ";
        echo "$oldNumber ";

        for ($i=1;$i<$num-1; $i++){
            echo "$result ";
            $result=$oldNumber+$newNumber+$midNumber;
            $oldNumber=$midNumber;
            $midNumber=$newNumber;
            $newNumber=$result;
        }
    }
    ?>

	<!--Write your PHP Script here-->
</body>
</html>