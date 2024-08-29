<?php
    $usuario_entrada = $_POST['usuario'];
    $senha_entrada = $_POST['senha'];

    $usuario_entrada = strtolower($usuario_entrada);
    $senha_entrada = strtolower($senha_entrada);

    $usuario = "Plinis";
    $senha = "1234";

    $usuario = strtolower($usuario);
    $senha = strtolower($senha);

    if ($usuario_entrada == $usuario && $senha_entrada == $senha){
        echo "Bvindo ".$usuario;
    } else {
        echo "Dados inválidos";
    }
?>
