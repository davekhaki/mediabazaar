<?php
if ($session_role=="Manager") {
  include("inc/manheader.php");
} elseif ($session_role=="Admin") {
  include("inc/adminheader.php");
}elseif ($session_role=="Employee"){
  include("inc/empheader.php");
}
?>
