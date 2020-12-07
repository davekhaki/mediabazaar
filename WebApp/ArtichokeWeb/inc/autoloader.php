<?php
spl_autoload_register('autoLoader');
function autoLoader($className){
$path="class/";
$extension=".class.php";
$fullPath = $path . $className. $extension;

include_once $fullPath;

}
 ?>
