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
}

$query_comments = "SELECT * FROM comments WHERE art_id = $note_id";
$result = mysqli_query($link,$query_comments);
$count_rows = mysqli_num_rows($result);
echo "<hr/>";
if($count_rows >= 1){
  while($comment = mysqli_fetch_array($result)){
    echo $comment ['author'],"<br/>";
    echo $comment ['comment'],"<br/>";
    echo $comment ['created'],"<br/>";
  }
}
else{
  echo "Комментариев пока не добавлено";
}

?>