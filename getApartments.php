<?php
$host = 'localhost';
$user = 'root';
$password = '';
$dbname = 'exchange_bureaux';

// Создаем соединение
$conn = mysqli_connect($host, $user, $password, $dbname);

// Проверка соединения
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

$sql = "SELECT * FROM apartments";
$result = mysqli_query($conn, $sql);

$apartments = array();
if (mysqli_num_rows($result) > 0) {
    while($row = mysqli_fetch_assoc($result)) {
        $apartment = array(
            "id" => $row["id"],
            "rooms" => $row["rooms"],
            "area" => $row["area"],
            "floor" => $row["floor"],
            "address" => $row["address"]
        );
        array_push($apartments, $apartment);
    }
}

header('Content-Type: application/json');
echo json_encode($apartments);
?>