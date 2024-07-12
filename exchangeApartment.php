<?php
header('Content-Type: application/json; charset=utf-8');

$jsonData = file_get_contents('php://input');
$data = json_decode($jsonData, true);

if (!isset($data['rooms']) || !isset($data['floor']) || !isset($data['area'])) {
    die(json_encode(array("error" => "Недостаточно данных")));
}

$rooms = intval($data['rooms']);
$floor = intval($data['floor']);
$area = intval($data['area']);

$host = 'localhost';
$user = 'root';
$password = '';
$dbname = 'exchange_bureaux';

// Создаем соединение
$conn = mysqli_connect($host, $user, $password, $dbname);

// Проверка соединения
if (!$conn) {
    die(json_encode(array("error" => "Connection failed: " . mysqli_connect_error())));
}

$sql = "SELECT * FROM apartments WHERE rooms = $rooms AND floor = $floor AND ABS(area - $area) / $area <= 0.1";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0) {
    $row = mysqli_fetch_assoc($result);
    $apartment = array(
        "id" => $row["id"],
        "rooms" => $row["rooms"],
        "area" => $row["area"],
        "floor" => $row["floor"],
        "address" => $row["address"]
    );

    // Удаление квартиры из базы данных
    $id = $row["id"];
    $sql = "DELETE FROM apartments WHERE id = $id";
    mysqli_query($conn, $sql);

    // Выводит сведения о квартире пользователю
    echo json_encode(array("apartment" => $apartment));
} else {
    // Добавляет запрос в список таблицы requests
    $sql = "INSERT INTO request (rooms, area, floor) VALUES ($rooms, $area, $floor)";
    mysqli_query($conn, $sql);

    // Возвращает пользователю сообщение
    echo json_encode(array("message" => "На данный момент такой квартиры не существует. Запрос добавлен в список."));
}
?>