<?php
if (isset($_GET['cel'])) {
    $value = floatval($_GET['cel']);
    $result = $value*1.8 +32;
    $msgAfterCelsius = "$value&deg C=$result&deg F";
    echo $msgAfterCelsius;
}
else if (isset($_GET['fah'])) {
    $value = floatval($_GET['fah']);
    $result = ($value-32)/1.8;
    $msgAfterCelsius = "$value&deg F=$result&deg C";
    echo $msgAfterCelsius;

}
else{
    $msgAfterCelsius="";
    echo $msgAfterCelsius;

}
?>




<form>
    Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?= $msgAfterCelsius ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
</form>
