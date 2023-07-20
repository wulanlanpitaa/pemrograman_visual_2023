Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
File name: makanan2_api.php
<?php
require_once 'database.php';
require_once 'Makanan2.php';
$db = new MySQLDatabase();
$makanan2 = new Makanan2($db);
$id=0;
$nokamar=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nokamar'])){
            $nokamar = $_GET['nokamar'];
        }
        if($id>0){    
            $result = $makanan2->get_by_id($id);
        }elseif($nokamar>0){
            $result = $makanan2->get_by_nokamar($nokamar);
        } else {
            $result = $makanan2->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new makanan2
        $makanan2->nokamar = $_POST['nokamar'];
        $makanan2->jenis_makanan = $_POST['jenis_makanan'];
        $makanan2->nama_makanan = $_POST['nama_makanan'];
        $makanan2->jumlah = $_POST['jumlah'];
        $makanan2->total_harga = $_POST['total_harga'];
       
        $makanan2->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Makanan2 created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Makanan2 not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nokamar'])){
            $nokamar = $_GET['nokamar'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $makanan2->nokamar = $_PUT['nokamar'];
        $makanan2->jenis_makanan = $_PUT['jenis_makanan'];
        $makanan2->nama_makanan = $_PUT['nama_makanan'];
        $makanan2->jumlah = $_PUT['jumlah'];
        $makanan2->total_harga = $_PUT['total_harga'];
        if($id>0){    
            $makanan2->update($id);
        }elseif($nokamar<>""){
            $makanan2->update_by_nokamar($nokamar);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Makanan2 updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Makanan2 update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['nokamar'])){
            $nokamar = $_GET['nokamar'];
        }
        if($id>0){    
            $makanan2->delete($id);
        }elseif($nokamar>0){
            $makanan2->delete_by_nokamar($nokamar);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Makanan2 deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Makanan2 delete failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>