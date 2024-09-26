<?php
    //puxa a coneccao
    require('conecta.php');

    //vem do login.html
    $email = $_POST['email'];
    $senha = $_POST['senha'];


    $consulta = "SELECT * FROM usuarios WHERE email = '$email' AND senha = '$senha'";

    $resultado = $conexao->query($consulta);
    //pega a quantidade de linhas entro da $resultado e atribui a uma variavel
    $registros = $resultado->num_rows;
  
    //pegou o objeto resultado e fez uma associacao de tudo q achou
    $resultado_usuario = mysqli_fetch_assoc($resultado);

    //esse detalha a variavel inteira, mostra valores, tipo; usa pra lista, obejto
    //var_dump($resultado_usuario);

    if($registros == 1){
        header('Location: index.php');
    }
    else{
        header('Location: ../index.html');
    }
?>
