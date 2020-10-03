<?php
$image_dir_path = $_SERVER['DOCUMENT_ROOT'] . "/Tasks/Laba_9/files/";
$image_dir_id = opendir($image_dir_path);
$array_files = null; 
$i = 0;
while(($path_to_file = readdir($image_dir_id)) !== false)
 {
 if(($path_to_file !=".") && ($path_to_file !=".."))
 {
 $array_files[$i] = basename($path_to_file);
 $i++;
 }
 }
closedir($image_dir_id);

?>
<h1>Это страница для работы с изображениями</h1>
<form name = "file_upload" action="files.php"
 enctype="multipart/form-data" method="post">
<input type="hidden" name="MAX_FILE_SIZE" value="1000000" />
<input type="file" name="file_upload" />
<input type="submit" name="submit" value="Добавить" />
</form> 
<?php
if (isset($_POST["MAX_FILE_SIZE"]))
 {
 $tmp_file_name = $_FILES["file_upload"]["tmp_name"];
 $dest_file_name = $_SERVER['DOCUMENT_ROOT'].
 "/Tasks/Laba_9/files/".$_FILES["file_upload"]["name"];
 move_uploaded_file($tmp_file_name, $dest_file_name);
 }
?> 
<?php

$array_files_count = count($array_files);
if ($array_files_count)
 {
 ?>
 <hr />
 <?php 
 sort($array_files);
 for ($i=0; $i<$array_files_count; $i++)
 {
 ?>
 <p>
 <?php echo $array_files[$i]; ?></p>
 <?php
 }
 ?>
 <hr />
 <form name="file_delete" action="files.php" method="post"
 enctype="application/x-www-form-urlencoded">
Файл <select name = "file_delete" size="1">
<?php for ($i=0; $i<$array_files_count; $i++) { ?>
<option><?php echo $array_files[$i]; ?></option>
<?php } ?></select>
<input type="submit" name="submit" value="Удалить" />
</form> 
<?php

if (isset($_POST["file_delete"]))
 { 
 $file_name = $_SERVER['DOCUMENT_ROOT'] . "/Tasks/Laba_9/files/".
 $_POST["file_delete"];
 if(is_file($file_name)){
  if(unlink($file_name)){
    echo "File was deleted";
  }
  else{
    echo "File wasnt delete";
  }
 }
 else{
   echo "File doesnt exist";
 }
 
 }
?>
 <?php
 }
?> 
<br>
<a href="blog.php">Вернуться на главную страницу сайта</a>