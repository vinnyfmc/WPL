using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WPL.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campeonato",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    NomeAbreviado = table.Column<string>(type: "varchar(10)", nullable: false),
                    ImagemLogo = table.Column<string>(type: "varchar(300)", nullable: true),
                    ImagemRegulamentoSugestao = table.Column<string>(type: "varchar(300)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    TipoSugestao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JogadorSenha",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Senha = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogadorSenha", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plataforma",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    NomeAbreviado = table.Column<string>(type: "varchar(5)", nullable: false),
                    ImagemLogo = table.Column<string>(type: "varchar(300)", nullable: true),
                    PlataformaDefault = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataforma", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posicao",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    NomeAbreviado = table.Column<string>(type: "varchar(5)", nullable: false),
                    Logo = table.Column<string>(type: "varchar(300)", nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posicao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampeonatoEdicao",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DataFim = table.Column<DateTime>(type: "DateTime", nullable: true),
                    ImagemLogo = table.Column<string>(type: "varchar(300)", nullable: true),
                    ImagemBanner = table.Column<string>(type: "varchar(300)", nullable: true),
                    ImagemPremiacao = table.Column<string>(type: "varchar(300)", nullable: true),
                    ImagemRegulamento = table.Column<string>(type: "varchar(300)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Tipo = table.Column<int>(nullable: false),
                    CampeonatoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoEdicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampeonatoEdicao_Campeonato_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampeonatoPlataforma",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CampeonatoId = table.Column<long>(nullable: false),
                    PlataformaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoPlataforma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampeonatoPlataforma_Campeonato_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampeonatoPlataforma_Plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataforma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    NomeAbreviado = table.Column<string>(type: "varchar(5)", nullable: false),
                    DataFundacao = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ImagemLogo = table.Column<string>(type: "varchar(300)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    PlataformaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Time_Plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataforma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogador",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    TagName = table.Column<string>(type: "varchar(20)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: true),
                    JogadorSenhaId = table.Column<long>(nullable: false),
                    PlataformaId = table.Column<long>(nullable: false),
                    PosicaoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogador_JogadorSenha_JogadorSenhaId",
                        column: x => x.JogadorSenhaId,
                        principalTable: "JogadorSenha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogador_Plataforma_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataforma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Jogador_Posicao_PosicaoId",
                        column: x => x.PosicaoId,
                        principalTable: "Posicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampeonatoEdicaoFase",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CampeonatoEdicaoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoEdicaoFase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampeonatoEdicaoFase_CampeonatoEdicao_CampeonatoEdicaoId",
                        column: x => x.CampeonatoEdicaoId,
                        principalTable: "CampeonatoEdicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CampeonatoEdicaoTime",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CampeonatoEdicaoId = table.Column<long>(nullable: false),
                    TimeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampeonatoEdicaoTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CampeonatoEdicaoTime_CampeonatoEdicao_CampeonatoEdicaoId",
                        column: x => x.CampeonatoEdicaoId,
                        principalTable: "CampeonatoEdicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampeonatoEdicaoTime_Time_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JogadorStatusHistorico",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    JogadorId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogadorStatusHistorico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JogadorStatusHistorico_Jogador_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeJogador",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    EhManager = table.Column<bool>(type: "bit", nullable: false),
                    EhSubManager = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PosicaoId = table.Column<long>(nullable: false),
                    JogadorId = table.Column<long>(nullable: false),
                    TimeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeJogador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeJogador_Jogador_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeJogador_Posicao_PosicaoId",
                        column: x => x.PosicaoId,
                        principalTable: "Posicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeJogador_Time_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jogo",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Data = table.Column<DateTime>(type: "DateTime", nullable: false),
                    GolsCasa = table.Column<int>(nullable: false),
                    GolsFora = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CampeonatoEdicaoFaseId = table.Column<long>(nullable: false),
                    TimeCasaId = table.Column<long>(nullable: false),
                    TimeForaId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jogo_CampeonatoEdicaoFase_CampeonatoEdicaoFaseId",
                        column: x => x.CampeonatoEdicaoFaseId,
                        principalTable: "CampeonatoEdicaoFase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JogoJogador",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    Gols = table.Column<int>(nullable: false),
                    Assistencias = table.Column<int>(nullable: false),
                    Nota = table.Column<decimal>(nullable: true),
                    CartaoAmarelo = table.Column<bool>(type: "bit", nullable: false),
                    CartaoVermelho = table.Column<bool>(type: "bit", nullable: false),
                    MelhorEmCampo = table.Column<bool>(type: "bit", nullable: false),
                    JogoId = table.Column<long>(nullable: false),
                    JogadorId = table.Column<long>(nullable: false),
                    PosicaoId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogoJogador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JogoJogador_Jogador_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogoJogador_Jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogoJogador_Posicao_PosicaoId",
                        column: x => x.PosicaoId,
                        principalTable: "Posicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JogoTime",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataCadastro = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorCadastro = table.Column<long>(nullable: true),
                    DataAlteracao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorAlteracao = table.Column<long>(nullable: true),
                    DataExclusao = table.Column<DateTime>(type: "DateTime", nullable: true),
                    IdJogadorExclusao = table.Column<long>(nullable: true),
                    GolsCasa = table.Column<int>(nullable: false),
                    GolsFora = table.Column<int>(nullable: false),
                    ImagemPlacar = table.Column<string>(type: "varchar(300)", nullable: true),
                    ImagemAssistencias = table.Column<string>(type: "varchar(300)", nullable: true),
                    ImagemGols = table.Column<string>(type: "varchar(300)", nullable: true),
                    ImagemNotas = table.Column<string>(type: "varchar(300)", nullable: true),
                    Confirmado = table.Column<int>(nullable: false),
                    JogoId = table.Column<long>(nullable: false),
                    TimeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JogoTime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JogoTime_Jogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "Jogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JogoTime_Time_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoEdicao_CampeonatoId",
                table: "CampeonatoEdicao",
                column: "CampeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoEdicaoFase_CampeonatoEdicaoId",
                table: "CampeonatoEdicaoFase",
                column: "CampeonatoEdicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoEdicaoTime_CampeonatoEdicaoId",
                table: "CampeonatoEdicaoTime",
                column: "CampeonatoEdicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoEdicaoTime_TimeId",
                table: "CampeonatoEdicaoTime",
                column: "TimeId");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoPlataforma_CampeonatoId",
                table: "CampeonatoPlataforma",
                column: "CampeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_CampeonatoPlataforma_PlataformaId",
                table: "CampeonatoPlataforma",
                column: "PlataformaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_JogadorSenhaId",
                table: "Jogador",
                column: "JogadorSenhaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_PlataformaId",
                table: "Jogador",
                column: "PlataformaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_PosicaoId",
                table: "Jogador",
                column: "PosicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_JogadorStatusHistorico_JogadorId",
                table: "JogadorStatusHistorico",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_CampeonatoEdicaoFaseId",
                table: "Jogo",
                column: "CampeonatoEdicaoFaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_TimeCasaId",
                table: "Jogo",
                column: "TimeCasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogo_TimeForaId",
                table: "Jogo",
                column: "TimeForaId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoJogador_JogadorId",
                table: "JogoJogador",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoJogador_JogoId",
                table: "JogoJogador",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoJogador_PosicaoId",
                table: "JogoJogador",
                column: "PosicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoTime_JogoId",
                table: "JogoTime",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_JogoTime_TimeId",
                table: "JogoTime",
                column: "TimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_PlataformaId",
                table: "Time",
                column: "PlataformaId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeJogador_JogadorId",
                table: "TimeJogador",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeJogador_PosicaoId",
                table: "TimeJogador",
                column: "PosicaoId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeJogador_TimeId",
                table: "TimeJogador",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogo_JogoTime_TimeCasaId",
                table: "Jogo",
                column: "TimeCasaId",
                principalTable: "JogoTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogo_JogoTime_TimeForaId",
                table: "Jogo",
                column: "TimeForaId",
                principalTable: "JogoTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CampeonatoEdicao_Campeonato_CampeonatoId",
                table: "CampeonatoEdicao");

            migrationBuilder.DropForeignKey(
                name: "FK_CampeonatoEdicaoFase_CampeonatoEdicao_CampeonatoEdicaoId",
                table: "CampeonatoEdicaoFase");

            migrationBuilder.DropForeignKey(
                name: "FK_JogoTime_Time_TimeId",
                table: "JogoTime");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_CampeonatoEdicaoFase_CampeonatoEdicaoFaseId",
                table: "Jogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_JogoTime_TimeCasaId",
                table: "Jogo");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogo_JogoTime_TimeForaId",
                table: "Jogo");

            migrationBuilder.DropTable(
                name: "CampeonatoEdicaoTime");

            migrationBuilder.DropTable(
                name: "CampeonatoPlataforma");

            migrationBuilder.DropTable(
                name: "JogadorStatusHistorico");

            migrationBuilder.DropTable(
                name: "JogoJogador");

            migrationBuilder.DropTable(
                name: "TimeJogador");

            migrationBuilder.DropTable(
                name: "Jogador");

            migrationBuilder.DropTable(
                name: "JogadorSenha");

            migrationBuilder.DropTable(
                name: "Posicao");

            migrationBuilder.DropTable(
                name: "Campeonato");

            migrationBuilder.DropTable(
                name: "CampeonatoEdicao");

            migrationBuilder.DropTable(
                name: "Time");

            migrationBuilder.DropTable(
                name: "Plataforma");

            migrationBuilder.DropTable(
                name: "CampeonatoEdicaoFase");

            migrationBuilder.DropTable(
                name: "JogoTime");

            migrationBuilder.DropTable(
                name: "Jogo");
        }
    }
}
