<header>
  <nav>
    <h1>MediaBazaar |  Welcome <?php echo $userDetails->FirstName;echo' | ';echo $session_role;?></h1>
    <ul id="navli">
      <li><a class="homeblack" href="home.php">HOME</a></li>
      <li><a class="homeblack" href="filetest.php">Update</a></li>
      <li><a class="homeblack" href="applyLeave.php">Apply Leave</a></li>
      <li><a class="homeblack" href="<?php echo BASE_URL; ?>logout.php">Log Out</a></li>
  </nav>
</header>
