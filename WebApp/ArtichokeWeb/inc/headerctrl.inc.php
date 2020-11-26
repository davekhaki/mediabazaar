<?php
if ($session_role="Manager") {
  include("manheader.php");
} elseif ($session_role="Admin") {
  include("adminheader.php");
}else {
  include("empheader.php");
}

?>
