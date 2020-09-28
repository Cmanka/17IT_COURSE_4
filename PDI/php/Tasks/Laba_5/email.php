<?php
if(!isset($_POST['title']) and !isset($_POST['message'])){
 ?> <form action="email.php" method="POST">
 <h3>Отправка сообщения</h3>
<input type="text" name="title" placeholder="Тема сообщения" required>
<input type="text" name="message" placeholder="Текст сообщения" required>
<input type="submit" value="Отправить"><br>
<p><a href="blog.php">На главную</a></p>
</form> <?php
} else {
 $title = $_POST['title'];
 $message = $_POST['message'];
 $title = htmlspecialchars($title);
 $message = htmlspecialchars($message);
 $title = urldecode($title);
 $message = urldecode($message);
 $title = trim($title);
 $message = trim($message);
 if (mail("example1@gmail.com", "Заявка с сайта", "Тема:".$title.". Сообщение: ".$message ,"From: example2@gmail.com \r\n")){
 echo "Сообщение успешно отправлено";
 } else {
 echo "При отправке сообщения возникли ошибки";
 }
}
?>