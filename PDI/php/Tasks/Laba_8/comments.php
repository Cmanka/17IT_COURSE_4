<?php
$link = mysqli_connect('localhost','admin','');
$db = "MySiteDB";
$select = mysqli_select_db($link,$db);

$note_id = $_GET['note'];
$query = "SELECT created,title,article FROM notes WHERE id = $note_id";
$result = mysqli_query($link,$query);
while($note = mysqli_fetch_array($result)){
echo $note ['title'],"<br/>";
echo $note ['article'],"<br/>";
echo $note ['created'],"<br/>";
}?>
<a href="editnote.php?note=<?php echo $note_id; ?>">Исправить заметку
</a><br>
<a href="deletenote.php?note=<?php echo $note_id; ?>">Удалить заметку
</a>
<?php 

$query_comments = "SELECT * FROM comments WHERE art_id = $note_id";
$result = mysqli_query($link,$query_comments);
$count_rows = mysqli_num_rows($result);
echo "<hr/>";

if($count_rows >= 1){
  while($comment = mysqli_fetch_array($result)){
    echo $comment ['author'],"<br/>";
    echo $comment ['comment'],"<br/>";
    echo $comment ['created'],"<br/>";?>
    <a href="deletecomment.php?comment=<?php echo $comment['id'];?>">Удалить комментарий</a><br>
    <?php
  }
}
else{
  echo "Комментариев пока не добавлено";
}
?>
<br>
<a href="newcomment.php?note=<?php echo $note_id; ?>">
Добавить комментарий</a>
<br>
<a href="blog.php">Вернуться на главную страницу сайта</a>

