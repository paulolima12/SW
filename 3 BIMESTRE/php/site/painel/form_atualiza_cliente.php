<?php
    include 'conecta.php';
    $id_clienteSelecionado = $_GET['id_cliente'];

    include 'menu.php';
?>

<div id="layoutSidenav_content">
    <main>
        <div class="container-fluid px-4">
            <h1 class="mt-4">Atualizar clientes</h1>
            <ol class="breadcrumb mb-4">
                <li class="breadcrumb-item"><a href="index.php">Painel de clientes</a></li>
                <li class="breadcrumb-item active">Atualizar clientes</li>
            </ol>
            <form action="atualiza_cliente.php?id_clienteSelecionado=<?php echo $id_clienteSelecionado; ?>"
                method="POST">

                <?php
                $sql = "SELECT * FROM clientes WHERE id_cliente = $id_clienteSelecionado";
                $consulta = $conexao->query($sql);
                while ($dados = $consulta->fetch_assoc()) {
                    ?>

                    <div class="mb-3">
                        <label for="nome_clienteNovo" class="form-label">Nome</label>
                        <input type="text" class="form-control" name="nome_clienteNovo"
                            value="<?php echo $dados['nome_cliente']; ?>">
                    </div>
                    <div class="mb-3">
                        <label for="email_clienteNovo" class="form-label">E-mail</label>
                        <input type="email" class="form-control" name="email_clienteNovo"
                            value="<?php echo $dados['email_cliente']; ?>">
                    </div>
                    <div class="mb-3">
                        <label for="telefoneNovo" class="form-label">Telefone</label>
                        <input type="text" class="form-control" name="telefoneNovo"
                            value="<?php echo $dados['telefone']; ?>">
                    </div>

                    <?php
                }
                ?>

                <button type="submit" class="btn btn-primary btn-sm">Atualizar</button>
                <button type="reset" class="btn btn-danger btn-sm">Apagar alterações</button>
            </form>
        </div>
    </main>
    <footer class="py-4 bg-light mt-auto">
        <div class="container-fluid px-4">
            <div class="d-flex align-items-center justify-content-between small">
                <div class="text-muted">Copyright &copy; Your Website 2023</div>
                <div>
                    <a href="#">Privacy Policy</a>
                    &middot;
                    <a href="#">Terms &amp; Conditions</a>
                </div>
            </div>
        </div>
    </footer>
</div>
</div>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"
    crossorigin="anonymous"></script>
<script src="js/scripts.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.min.js" crossorigin="anonymous"></script>
<script src="assets/demo/chart-area-demo.js"></script>
<script src="assets/demo/chart-bar-demo.js"></script>
<script src="assets/demo/chart-pie-demo.js"></script>
</body>

</html>