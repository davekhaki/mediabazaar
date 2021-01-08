<?php
spl_autoload_register('autoLoader');
function autoLoader($className){
$path="logic/";
$extension=".logic.php";
$fullPath = $path . $className. $extension;

include_once $fullPath;

}
 ?>
