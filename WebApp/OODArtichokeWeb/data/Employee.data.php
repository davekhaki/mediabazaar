<?php

class Employee extends User{
  // how can i parametize a prepare stament for this query isntead of using query with prepare
  public function viewSchedule($empId){
$sql="SELECT TimeOfDay,DATE_FORMAT(Day, '%d-%b-%y') AS Day FROM schedule WHERE EmployeeID=:empId GROUP BY Day,TimeOfDay ORDER BY date(Day), CASE WHEN TimeOfDay='Morning' THEN '1' WHEN TimeOfDay='Afternoon' THEN '2'WHEN TimeOfDay='Evening' THEN '3'  END ";
$stmt = $this->connect()->prepare($sql);
$stmt->bindParam("empId", $empId,PDO::PARAM_STR);
$stmt->execute();
 $schedule=$stmt->fetchAll();
  //<td>".$stock['Name']."</td>
  echo '<th align = "center">TimeofDay</th>';
  echo '<th align = "center">Day</th>';
   foreach ($schedule as $stock) {

      echo "<tr>
         <td>".$stock['TimeOfDay']."</td>
           <td>".$stock['Day']."</td></tr>";
  }
}
}
