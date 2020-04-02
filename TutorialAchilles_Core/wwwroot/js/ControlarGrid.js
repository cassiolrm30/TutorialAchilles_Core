var controller = "Livro";
var qtRegistrosPorPagina = 10;
var titulos = [];
var totalRegistros;
titulos.push({ valor: "Titulo", texto: "Título", percentual: "44", ascendente: true });
titulos.push({ valor: "Autor", texto: "Autor", percentual: "20", ascendente: true });
titulos.push({ valor: "AnoEdicao", texto: "Ano da Edição", percentual: "12", ascendente: true });
titulos.push({ valor: "Valor", texto: "Valor", percentual: "13", ascendente: true });
titulos.push({ valor: "{{ctx.name}}", texto: "", percentual: "11", ascendente: true });
var ordenarPorCampo = titulos[0].valor;
var ordenarPorSentido = titulos[0].ascendente;
var paginaCorrente;

function editar(id)
{
    alert(id);
}

function excluir(id)
{
    if (confirm("Tem certeza que deseja excluir este registro?")) {
        alert(id);
        $.ajax({
            type: "POST",
            url: _endereco_corrente + "/Excluir/",
            data: { Id: id },
            dataType: "json",
            async: false,
            cache: false,
            success: function (data) {
                definirGrid(paginaCorrente);
                alert(data.mensagem);
            },
            error: function (e) { alert("Erro interno"); }
        });
    }
}

function getRegistros(pagina)
{
    var registros = [];
    var filtro = "";
    $.ajax({
        type: "GET",
        url: _endereco_corrente + "/Listar/",
        data: { paginaCorrente: pagina, qtLinhas: qtRegistrosPorPagina, filtro: (filtro == null ? "" : filtro), ordenarPorCampo: ordenarPorCampo, ordenarPorSentido: (ordenarPorSentido ? "ASC" : "DESC") },
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        async: false,
        cache: false,
        success: function (data) {
            //console.log(JSON.stringify(data));
            registros = data.rows;
            totalRegistros = data.total;
        },
        error: function (e) { alert("Erro interno"); }
    });
    return registros;
}

function definirAgrupamento()
{
    var combo = "";
    combo += "<button class='btn btn-default dropdown-toggle' type='button' data-toggle='dropdown'>";
    combo += "<span class='dropdown-text' id='spanLinhasPorPagina'>10</span> <span class='caret'></span></button>";
    combo += "<ul class='dropdown-menu pull-right' role='menu' id='ulLinhasPorPagina'>";
    combo += "<li class='active' aria-selected='true'><a data-action='10' class='dropdown-item dropdown-item-button'>10</a></li>";
    combo += "<li aria-selected='false'><a data-action='25' class='dropdown-item dropdown-item-button'>25</a></li>";
    combo += "<li aria-selected='false'><a data-action='50' class='dropdown-item dropdown-item-button'>50</a></li>";
    combo += "<li aria-selected='false'><a data-action='-1' class='dropdown-item dropdown-item-button'>All</a></li>";
    combo += "</ul>";
    $("#grp1").html(combo);

    combo = "";
    combo += "<button class='btn btn-default dropdown-toggle' type='button' data-toggle='dropdown'>";
    combo += "<span class='dropdown-text'><span class='icon glyphicon glyphicon-th-list'></span></span> <span class='caret'></span>";
    combo += "</button>";
    combo += "<ul class='dropdown-menu pull-right' role='menu'>";
    for (var i = 0; i < titulos.length; i++)
        combo += "<li><label class='dropdown-item'><input type='checkbox' value='1' class='dropdown-item-checkbox' checked='checked' name='" + titulos[i].valor + "'> " + titulos[i].texto + "</label></li>";
    combo += "</ul>";
    $("#grp2").html(combo);
}

function definirGrid(pagina)
{
    var registros = getRegistros(pagina);
    var resultado = "";
    resultado += "<table id='gridDados' class='table table-striped bootgrid-table' style='width:" + $("#gridDados-header .row").css("width") + ";' aria-busy='false'>";
    resultado += "<thead>";
    resultado += "<tr>";
    for (var i = 0; i < titulos.length; i++) {
        resultado += "<th class='text-left' data-column-id='" + titulos[i].valor + "' style='width:" + titulos[i].percentual + "%;'>";
        if (titulos[i].texto != "") {
            resultado += "<a href='javascript:void(0);' class='column-header-anchor sortable'><span class='text' href='#' onclick=\"ordenarGridPorCampo(" + pagina + ", " + i + ");\">" + titulos[i].texto + "</span>";
            resultado += " <span class='icon glyphicon glyphicon-chevron-" + ((titulos[i].ascendente) ? "up" : "down") + "' id='ord_" + titulos[i].valor + "'></span></a>";
        }
        resultado += "</th>";
    }
    resultado += "</tr>";
    resultado += "</thead>";
    resultado += "<tbody>";
    for (var i = 0; i < registros.length; i++) {
        resultado += "<tr data-row-id='" + i + "'>";
        resultado += "<td class='text-left'>" + registros[i].titulo + "</td>";
        resultado += "<td class='text-left'>" + registros[i].autor + "</td>";
        resultado += "<td class='text-left'>" + registros[i].anoEdicao + "</td>";
        resultado += "<td class='text-left'>" + registros[i].valor + "</td>";
        resultado += "<td class='text-right' style='padding-left:20px;'>";
        resultado += "<a href='#' onclick='editar(" + registros[i].id + ");' class='btn btn-warning'><span class='glyphicon glyphicon-edit'></span></a> ";
        resultado += "<a href='#' onclick='excluir(" + registros[i].id + ");' class='btn btn-danger'><span class='glyphicon glyphicon-trash'></span></a>";
        resultado += "</td>";
        resultado += "</tr>";
    }
    resultado += "</tbody>";
    resultado += "</table>";
    $("#divGrid").html(resultado);

    montarRodape(pagina);
    paginaCorrente = pagina;
}

function ordenarGridPorCampo(pagina, i)
{
    var campoTitulo = titulos[i];
    ordenarPorCampo = campoTitulo.valor;
    ordenarPorSentido = !(campoTitulo.ascendente);
    titulos[i].valor = ordenarPorCampo;
    titulos[i].ascendente = ordenarPorSentido;
    definirGrid(pagina);
}

function montarRodape(paginaAtual) {
    var qtPaginas = (totalRegistros / qtRegistrosPorPagina).toFixed(0);
    var resultado = "";
    if (qtPaginas > 1) {
        var v_disabled_esq = (paginaAtual === 1) ? " disabled'" : "' style='cursor:pointer;'";
        var v_disabled_dir = (paginaAtual === qtPaginas) ? " disabled'" : "' style='cursor:pointer;'";
        var v_anterior = (paginaAtual === 1) ? 1 : (paginaAtual - 1);
        var v_proximo = (paginaAtual === qtPaginas) ? qtPaginas : (paginaAtual + 1);
        resultado += "<ul class='pagination'>";
        resultado += "<li class='first" + v_disabled_esq + "' aria-disabled='true'><a data-page='first' class='button' href='#' onclick='definirGrid(1);'>«</a></li>";
        resultado += "<li class='prev" + v_disabled_esq + "' aria-disabled='true'><a data-page='prev' class='button' href='#' onclick='definirGrid(" + v_anterior + ");'>&lt;</a></li>";
        for (var i = 1; i <= qtPaginas; i++) {
            var v_aria_selected = (i == paginaAtual) ? "true" : "false";
            var v_active = (i == paginaAtual) ? " active'" : "' style='cursor:pointer;'";
            resultado += "<li class='page-" + i + v_active + " aria-disabled='false' aria-selected='" + v_aria_selected + "'><a data-page='" + i + "' class='button' href='#' onclick='definirGrid(" + i + ");'>" + i + "</a></li>";
        }
        resultado += "<li class='next" + v_disabled_dir + " aria-disabled='false'><a data-page='next' class='button' href='#' onclick='definirGrid(" + v_proximo + ");'>&gt;</a></li>";
        resultado += "<li class='last" + v_disabled_dir + " aria-disabled='false'><a data-page='last' class='button' href='#' onclick='definirGrid(" + qtPaginas + ");'>»</a></li>";
        resultado += "</ul>";
    }
    $("div[class='col-sm-6']").html(resultado);
    $("div[class='col-sm-6 infoBar']").html("Exibindo 1 até " + qtRegistrosPorPagina + " de " + totalRegistros + " registros");
}

function abrirModal(parametro)
{
    var url = "/{ctrl}/Cadastro/{parametro}";
    url = url.replace("{ctrl}", controller);
    url = url.replace("{parametro}", (parametro != null) ? parametro : "");
    //debugger;
    $("#conteudoModal").load(url, function ()
    {
        //$("#minhaModal").modal('show');
        $("#myModal").modal('show');
    });
}

$("#ulLinhasPorPagina").click(function () {
    $("#spanLinhasPorPagina").html("25");
    alert($(this).prop("class"));
    //console.log($(this).prop("aria-selected"));
});

$("#btnNovo").click(function () {
    abrirModal();
});