Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
<?php
//Simpanlah dengan nama file : Makanan2.php
require_once 'database.php';
class Makanan2 
{
    private $db;
    private $table = 'makanan2';
    public $nokamar = "";
    public $jenis_makanan = "";
    public $nama_makanan = "";
    public $jumlah = "";
    public $total_harga = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function get_by_nokamar(int $nokamar)
    {
        $query = "SELECT * FROM $this->table WHERE nokamar = $nokamar";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`nokamar`,`jenis_makanan`,`nama_makanan`,`jumlah`,`total_harga`) VALUES ('$this->nokamar','$this->jenis_makanan','$this->nama_makanan','$this->jumlah','$this->total_harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET nokamar = '$this->nokamar', jenis_makanan = '$this->jenis_makanan', nama_makanan = '$this->nama_makanan', jumlah = '$this->jumlah', total_harga = '$this->total_harga' 
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_nokamar($nokamar): int
    {
        $query = "UPDATE $this->table SET nokamar = '$this->nokamar', jenis_makanan = '$this->jenis_makanan', nama_makanan = '$this->nama_makanan', jumlah = '$this->jumlah', total_harga = '$this->total_harga' 
        WHERE nokamar = $nokamar";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_nokamar($nokamar): int
    {
        $query = "DELETE FROM $this->table WHERE nokamar = $nokamar";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>