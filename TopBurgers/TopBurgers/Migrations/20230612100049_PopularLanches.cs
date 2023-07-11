using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopBurgers.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque) " +
                "VALUES(1,'Mega Cheddar 3.0','O Mega Cheddar 3.0 foi feito para aqueles que gostam de grandes desafios e cheddar é claro!','Pão de batata, 3 hambúrgueres de 120g, 3 camadas de cheddar, salada de alface, picles e molho do Chef.', 32.90, '/images/Produtos/LanchesArtesanais/Mega_Cheddar_3.0.png','/images/ThumbNails/LanchesArtesanais/Thumb_Mega_Cheddar_3.0.png',1,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque) " +
              "VALUES(1,'Salada Crunch', 'A combinação perfeita para aqueles que amam onion rings.','Pão de batata, hambúrguer de 180g, onion rings (aneis de cebola), bacon, cheddar, salada de alface, tomate, cebola, molho barbercue.', 27.90, '/images/Produtos/LanchesArtesanais/Salada_Crunch.png','/images/ThumbNails/LanchesArtesanais/Thumb_Salada_Crunch.png',1,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque) " +
           "VALUES(1,'Cheddarburger', 'Um lanche explosivo de sabor com cheddar derretido e hambúrguer suculento.','Pão de cenoura, hambúrguer de 180g, cheddar e cebola caramelizada.', 25.90, '/images/Produtos/LanchesArtesanais/Cheddarburger.png','/images/ThumbNails/LanchesArtesanais/Thumb_Cheddarburger.png',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque) " +
           "VALUES(1,'Creamyburger', 'Um lanche feito com cream cheese e um hambúrguer suculento','Pão de batata, hambúrguer de 180g, cheddar e cebola caramelizada, cream cheese, maionese temperada e molho barbecue.', 25.90, '/images/Produtos/LanchesArtesanais/Creamyburger.png','/images/ThumbNails/LanchesArtesanais/Thumb_Creamyburger.png',0,1)");


            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque) " +
           "VALUES(1,'Duplo Salada', 'O lanche é acompanho por duas camadas de saladas','Pão com gergelim, hambúrguer de 180g, cheddar, alface, tomate e cebola rocha', 22.90, '/images/Produtos/LanchesArtesanais/Duplo_Salad.png','/images/ThumbNails/LanchesArtesanais/Thumb_Duplo_Salad.png',0,1)");

            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId,Nome,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsLanchePreferido,EmEstoque) " +
          "VALUES(1,'Megacrispy', 'Lanche completo e com os melhores ingredientes','Pão com gergelim, hambúrguer de 180g, bacon, cheddar, alface, tomate, picles e molho de mostarda e mel', 28.90, '/images/Produtos/LanchesArtesanais/Megacrispy.png','/images/ThumbNails/LanchesArtesanais/Thumb_Megacrispy.png',1,1)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
