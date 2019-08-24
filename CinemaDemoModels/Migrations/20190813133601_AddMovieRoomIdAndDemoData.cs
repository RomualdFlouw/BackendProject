using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CinemaDemoModels.Migrations
{
    public partial class AddMovieRoomIdAndDemoData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "MovieRooms",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2748aa24-9837-40a7-a21e-be6b437df72a"), "Kinepolis Kortrijk" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CinemaId", "Nr" },
                values: new object[,]
                {
                    { new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), new Guid("2748aa24-9837-40a7-a21e-be6b437df72a"), 0 },
                    { new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), new Guid("2748aa24-9837-40a7-a21e-be6b437df72a"), 1 },
                    { new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), new Guid("2748aa24-9837-40a7-a21e-be6b437df72a"), 2 },
                    { new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), new Guid("2748aa24-9837-40a7-a21e-be6b437df72a"), 3 },
                    { new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), new Guid("2748aa24-9837-40a7-a21e-be6b437df72a"), 4 }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "Nr", "RoomId", "RowNr" },
                values: new object[,]
                {
                    { new Guid("ac298b2f-9fc6-410c-9c4a-997bf8d9344f"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("76a7f9d2-c1d8-45ac-a2e5-ac37e9a3f394"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("59633c3a-4498-4259-b815-0b824aa86885"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("4cc7d28d-6d07-4170-b195-c216c496bf6c"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("3293d8bb-31f0-4a87-ac83-c81bfacbd5fb"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("d2903645-f16f-4d9c-b0f7-47fc636cebee"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("17763cb4-9e4b-4ea4-b529-35e0c960a2e2"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("b13cb0a7-af31-4849-afaf-06ad8856ef51"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("009394a3-8d5c-4b9c-b848-61487ccc7ec0"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("5239d9bb-2f7f-4d33-a6d3-19a11c1f25d9"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("be5cb93b-9e7a-4c5a-bdbd-908e80b7a099"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("22ac6fab-647b-4673-ae25-2f9012b58180"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("95614c8a-61ad-467f-94bd-90532b031ac7"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 3 },
                    { new Guid("40cfd45d-79ed-479d-acc7-788a62c17158"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("b48f73b0-fce0-4a29-9cd2-198a4036b299"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("ae766d31-5485-43af-8b28-dc910e6fc121"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("60163fc7-f1bb-453a-845f-d98b5772c70c"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("6e98c15b-6d8a-43d6-9033-612579c107ce"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("c62239a3-3d1c-4d73-aa8e-a3031adaeebe"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("96a60f49-052d-45db-b052-21a6199b7570"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("40ff88ad-a447-4603-8d15-6dbfe11ece9e"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("8af6f3bf-9ed4-4c50-b6e2-479c1441c66f"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("99873958-e3be-4961-93f6-1d03403b59e1"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 2 },
                    { new Guid("cabfbc7c-7c7e-4935-ba88-95f0c5b2ba93"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("ce039e9e-9e39-4d26-b834-d275045d2929"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("e7942202-9522-4a97-9621-fcafd8433f0a"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("e3d46bfc-8a73-4c4a-9ce2-a5bfab146e90"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("7f214471-0899-439b-9b3a-e6b5f2e7f3fc"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("c435f25c-5c45-4238-b604-33672596441f"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("6ca2fda9-6047-4791-a4ec-50819dcfcf0e"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("2bac45dc-e101-4cd8-afaa-ff79c23f7692"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("0bfbeac4-8d64-4b65-a89b-82d8659ec051"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("8d1fac2d-964c-48f5-b64b-645e4404e6ee"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("c499d32c-3f06-45ce-a41a-df09f752a5b9"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("81034dac-e856-4347-8050-2f92c701c543"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("8c79dd0b-71f4-4a93-8c4e-3c20e378a050"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("09ded0fe-6699-469f-941d-a4be7749b8e2"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("bc82cf70-a1ec-46d9-8fc8-5796d37fb49c"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("ec1db9a9-6fce-4222-b9f9-cafc0d5f70a4"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("da56b40a-7c82-46ce-9518-9c163c32c1f3"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("dd5d68a6-7fc1-4923-98de-278fe24bdbf8"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("49c6d5e5-3b71-4281-8107-3201b09a7f55"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("ea719863-80b5-4966-9ff8-33094236205f"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("09f1e613-1732-43ec-9673-e51638078444"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("667c189e-a164-4fba-a677-6181f1bc119d"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 6 },
                    { new Guid("eb78cd71-b295-40b2-b65d-e281e91a1df1"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("32d1e10b-8d63-470b-9395-cfb4e3a53b03"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("511e0a64-5133-4a9a-a128-143ae3effc3c"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("6dbd21db-a7b4-4181-ac59-3944c66f31eb"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("539c3739-23f7-407a-a99e-63ec445596fb"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("5298bb68-1b90-4c34-949f-abcecc2db6d6"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("650e0a38-47c3-4761-a6d4-d37dcf0d7893"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("2a662451-5cd6-41c6-b24b-94177247cd37"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("10974b12-85f9-420f-859c-e4a113f55881"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("3b2a1be2-87eb-4c16-9f59-5e8125a273e5"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 5 },
                    { new Guid("73d74b45-1417-4ef6-98e0-3617fbb813b0"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("81b9a7f4-4635-465b-af3d-c94449d34f21"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("e4b76e72-4e2e-4008-9399-11ea7b6d53b8"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("1f4b2168-cd5a-4d6e-9a1f-9171f76de3c8"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("6b14194e-949b-4b03-a0a1-c602a1646038"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 4 },
                    { new Guid("3ad09cd9-4ff7-407e-9df2-d2dd0696a4ad"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("4ca8fc01-302c-4fb0-a70c-09eda626983e"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("7130adbc-003b-4df0-af86-d296c605ff64"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("6df32f8f-75ec-48b0-bb72-90d9013faaec"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("0b6a2f61-6ff3-43dc-99ae-7e2f78ecba9e"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("9242499b-724f-49cb-9171-3f38a5dec69b"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("d41ffd02-b4c6-40f7-9ca7-e6be84689703"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("9a2661dd-b74c-4519-9b7b-3f1d353c5527"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("6fe92734-3c95-4f62-8ecf-bf7f6d6b560a"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("8f1d05db-25eb-4e8e-a55d-6ae8997e2ef8"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("53d997a1-1ddc-4fdf-9834-c3f53d5be707"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("4f95ca57-7c97-4587-9cec-7ef024382882"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("4345ded7-c2c8-4e66-8abd-b03e554494f2"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("488a4c66-2b3a-429a-9761-7697d24815a7"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("01e5432f-6b6c-4acc-a92f-acce342f6588"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("80d103cd-7af2-4253-a7db-7a6a139fd4ac"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("6bd0d8a2-e97e-4d41-9f8b-8fa6229205c6"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("84a5581d-cb29-4449-b850-b1a1120bc29d"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("f292da0e-4b45-4361-b52d-2048bdfe7ec2"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("26274ee7-045d-4915-a24e-d11499a5e84f"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("54272068-03d0-4779-9b36-ab837f5c8dd7"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("68b0c9e7-f857-4b05-b7db-db5af6ea8a35"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 6 },
                    { new Guid("56829324-c0ca-4b4d-960c-35e7d08c4a97"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("68081bc5-caf5-4859-af03-34df4851209a"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("4ef278ad-0741-4a9d-91b3-856cf9d2ee25"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("a36f6923-bfd7-4081-87a6-cc296bcfd3ad"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("37a731ba-1d5a-4b87-bce9-0c47f39d8a5d"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("75d1e7c7-65e9-4a0c-91b7-4cf0165045f6"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("2769bbd0-923f-41b9-9022-f24db6c0f04c"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("f0c4607d-418b-4289-9a9a-4d61b54c9f83"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("f15e4c7a-3879-4e95-819e-1b42f73973d1"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 7 },
                    { new Guid("637ff249-3f4d-4eae-a7c4-f3ecbea28661"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("d2bbd1ce-d457-4ef9-b5f8-ce560413950f"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("0be650b2-507c-4212-aa43-7e8832eb7cb5"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("8b0fee1b-d61b-4dbb-9b22-15a77bdedd07"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 1 },
                    { new Guid("218e17f5-a56d-4c68-9665-16ec93bb9170"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("9c686e5f-5ba2-4eca-b7a7-cd6244ec2a03"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("b25664b3-79a4-4d69-89cd-03078748c82c"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("4ee373ad-cccd-465a-a636-cdd644414ec7"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("d23b4c2f-62b2-4541-afa3-953962bdfb76"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("4fb006c0-636f-44a0-ac1c-277ba8f271f5"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("558b4f57-229d-480b-89c4-e50f954910de"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("b0056fbb-139b-42ed-be49-46898d4155bb"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("6da36955-9ce7-4fbe-93bb-2b4bf4747a04"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("e1672997-6644-457a-b96c-f91371f00b40"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 0 },
                    { new Guid("1fcf077e-796a-4b4e-9d8b-794a5815db0b"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("8cf6bdfd-4c50-4667-a0fa-2434849be002"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("557d1d0f-b52b-47ea-bec3-e6052f4bd4ed"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("9fb1ff22-6569-4524-9961-14d005aab8db"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("ad16bc50-4f2f-4ea7-a4cd-a87a1ee8de9e"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("db14cbf9-8b73-4408-b7f9-f953bcce1a3f"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("e118a847-a263-4151-87a6-737aece03215"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("f74cce81-d883-4e26-b6b2-7f76ff706139"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("3793922d-8580-4dae-8b13-c2dae60d90c6"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("651bed61-2ff1-4762-ad30-a61d99747e76"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("b97b31a9-d4a0-4a5c-8733-ab7c9b3a492f"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("56bb9cb2-ed1b-4e9a-a83d-5c11ece5a09d"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("f0c124c4-c8e7-4fbb-9044-9fbee3402ee0"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("5b815a1c-708e-412a-a477-7527dbbd8a92"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("09ad1b5e-6562-4332-aa57-3e79da1bd1ab"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("04c1d8eb-248c-4e0b-92e4-899c75124317"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("1aa0a0ae-c8db-438b-8871-511b293e1cae"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 8 },
                    { new Guid("e068ad93-4acc-48db-989d-f9e62e2e2938"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 9 },
                    { new Guid("caf8a03b-fa56-4227-8239-f5e155c12e68"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("5b253db5-c34e-4fb9-82fe-348b08284b34"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("43e6dfa0-38b7-49db-a200-1f2fd001d616"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("a06f6145-29b2-4351-a14a-e14c076071b0"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("7ecfe9ce-8615-4cc8-a977-1301da584d6c"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("4560a07c-1f9e-4246-826f-6f00a7adb1c1"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("d1460fee-37a9-4532-ba1e-fb989a79a76a"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("e58bb543-dfbc-4b4d-b9f5-bf0d41add664"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("73b5f725-93ad-4760-9663-05ca2f5facf2"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("d6ef232b-1a88-446c-a1f8-9d55ccc06970"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("1299891d-74cc-4967-9b01-b516ef6bd3bd"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("cb06e201-494a-4732-9d2a-fdec20ab65be"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("01f6b10b-2f51-4d02-a602-627554f8961e"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("9e030dcf-58e5-4a48-99a7-9aab4ccffe0e"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("c73b0bba-cf1d-4e83-b8b6-10795cad23d3"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("0aa08517-ffbb-4bec-be33-675d02dae2ef"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("18da086b-2a1d-4cbe-8cd2-343ede0e68c8"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("0dc66719-2348-4ad8-b4fe-b92fe50b8de8"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("50b3a33d-fb27-4c89-8603-ac9ef6e7cc8c"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("0cda7845-bd78-478e-8b99-198a7071470c"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 5 },
                    { new Guid("e869dbb4-1a10-47ce-a913-d30d94a83421"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("77dd6473-a57a-484f-9c1e-2dcb0db45c0f"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("cfaeecf5-7a0c-4016-9f7b-d8223503228a"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("a4265d0e-2bc1-4853-82f5-0e2dde16de05"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("b56e24d0-a254-4ead-a0b3-276fb7d014d9"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("a31b1f19-3634-4e07-88bc-4d7adb15c409"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("945fce00-cdff-4ecd-b036-1cb6e3306314"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("cf8adae5-b2b1-44ef-84e6-873005dce63e"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("fa608550-0523-447c-a542-56528b6e2d4e"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("3e96720b-f44a-489e-aba2-24cb26902a2d"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 4 },
                    { new Guid("382989bc-73b4-4f1a-a37f-95c0d5a4c052"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("9b1c00eb-41b9-44c7-b6ad-8b269d06a127"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("44c0e039-2330-4b23-8532-bfc7ab150973"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("8ffa7f61-8d3e-47b4-ab84-404d37c7fc0f"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("42f5ccb5-d592-4e74-99db-106eb9a1f696"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("37e39705-9fd1-4942-a8f9-395166d0a090"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("972e6a69-3428-4484-99cc-c183bea6b9d8"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("b78b8820-1516-4088-be7b-184514f8f56f"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("66c79268-73e1-4ccb-83ad-b924b832fcb1"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("c2ebdc55-703e-42cf-8cee-4db0f6920590"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("f5ba77c8-e227-48e8-b3d3-40300f9c03f9"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("4fdd9945-5b33-4a09-8a7a-af3ca8bc910a"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("b1811042-50d4-43e5-91bd-bc373acd44e6"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("96861da4-882f-4b21-8cd6-84c4f43cf865"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("0422c05c-7267-40cf-9187-51591ec9f8dc"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("afbdc4fb-13b8-46b2-aaa3-5575496a7983"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("e1e7b0a4-30d0-40e9-ad5e-d64798b9a10c"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("17d10c29-4cd3-4fe4-8b52-11f904e5838a"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("d64d6678-1a23-4051-a872-2c91b030dab5"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("c2da5c45-f0e4-46ed-b397-20625c0637cc"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("5eb1d0c4-8f00-4f4a-87bb-a68b7b246cdd"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("972a5963-8313-4e74-9949-53fc9537f3ae"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 8 },
                    { new Guid("6617c5f8-85ac-4ebb-a825-ef0dc34edce7"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("0e1ff835-5e5e-4a6f-b28c-9e8c0f71d0e9"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("60391eb3-ee7c-4d1c-ac4f-7b45ce0a277f"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("03cadd92-a050-4b77-addc-8a60887506c9"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("a9aea3b3-33be-4e9b-9fd4-0d17f8469cc9"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("ccc22e0d-2c30-4a31-9ae8-6c6a335a0509"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("40b239c2-0525-4261-9538-8ed165fb250e"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("efd266bd-b8c5-4c86-9b44-ae41b262b090"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("ad365313-cad2-40e9-beea-7bb78e14d7f6"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 7 },
                    { new Guid("eec08cce-ec39-4251-b59b-939d118bfb7a"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 6 },
                    { new Guid("5be67098-edd7-4541-b4a2-c4c9244257eb"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("c761608f-0ec1-4b0d-af5e-8b505eb90a64"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("cd1b1661-697b-47ff-b0ad-49a262624094"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("800e3ef1-430b-4127-b097-1c28b931b002"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("7f5b8647-ea8a-463d-9c69-29f192704b99"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("122c0d5f-3356-484f-aa08-894d2a5483b7"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("9d9b40e8-324d-4e1a-98cb-1bef83deebc6"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("4d5cc8bd-b087-418a-959d-4bc787f34aa5"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("e3bcb579-fa68-4887-9215-f3dbaa128b4e"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("2c28bc3d-df77-4374-b4e8-25d1df447a61"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("b350286e-ca3f-4c76-9ac6-8c39ea8eef53"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("28dd7242-dad0-4100-a886-32db1eb0dea3"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("da16bf33-38a2-418c-932c-b0a1d5fcc149"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("39ccdf45-4a6c-4587-bfd9-b8d1f9121fcb"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("ac32d4d0-fe4b-4188-9492-44208b20f92e"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("16ebd77e-45b7-4648-a45a-b4bf952b6669"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("f29e1d6f-b71b-456f-ba96-d6d8928eb9fb"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 9 },
                    { new Guid("49fef3e0-9ea9-4717-9495-9e4e79c1b97f"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("06146bed-d7ef-4a9c-8f54-091d2be5528d"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("7789f3fd-6845-4cda-a26a-5a51c33cd332"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("656ea4de-0aff-49bf-8422-0962fe124610"), 6, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("44801577-2140-40ec-bec1-2ce799f81f32"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("51f53d0d-8f65-4c37-8261-7749da114fb2"), 4, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("767e0f99-9d3c-418a-b128-b51f685f0475"), 3, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("72f83749-1d7b-47c5-acf2-f4822a7691b0"), 2, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("c627c772-8715-40d5-8ad2-71ce6fd2711a"), 1, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("b476fdff-a187-4da9-9115-e149655d442f"), 0, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 8 },
                    { new Guid("0d358955-f329-40e2-986b-3d92bbc6fe3f"), 9, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("14094ae3-56d7-414d-8891-21ddf9c43255"), 8, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("ba23768b-fee9-4be8-acb9-0304cddc3609"), 7, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("b7be911f-c423-471d-b536-50add8c8922d"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("fb81d59f-3f8a-4f77-aa10-7dfbdaedb407"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("4bf5c364-eb8f-41bb-bdb3-e46e2b95db65"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("2cd8e0d2-0bf0-44d7-a7e5-a5de4e529f70"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("b7c3cb4c-6fef-411e-b96a-952aa1531062"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("fedfc43b-a8f1-4988-8f16-674b91557647"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("00e88f99-3741-4b65-b83f-841765404716"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("6688e005-efdf-4cd9-a275-57b4ea5cc4f3"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("1dbc0e30-844d-42d8-9cfe-c357f75d9aaa"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("2d280ff8-ad74-4b76-bb4b-ff7a3b292d9a"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 3 },
                    { new Guid("6cce6d76-a431-4698-bcff-01d7d403d494"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("a8ecd724-763c-4a81-8c51-287c4624679f"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("2ff6f02e-f560-4413-87ba-6f3b9fa4338c"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("fe8f1583-182c-42cc-bb9c-213df80c5745"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("dabc87a8-ad52-45e7-9f6d-214a235649bc"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("09acd0a4-480e-4b2d-90d4-5b1d971a02db"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("ebf2c0e3-038d-4306-b472-027d52ff8587"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("e9d4d763-39e9-4fbc-8dd9-d6b8e46324f9"), 5, new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"), 7 },
                    { new Guid("fbc71790-dc96-4fae-9a25-1cfb60226ba6"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("11065b30-bcdf-4732-bf3d-413aa6faca3c"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("7350a01a-9fd4-4d14-a96d-206239125767"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("09011512-f37f-4b06-a462-70efc50dd30f"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("6d9b26fa-fa80-45ca-9b25-e189f9e15626"), 7, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("89008b72-0495-49de-b328-93d4b47e74fd"), 6, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("c8dda5c4-d70e-4d08-837f-9e963d2f7aa2"), 5, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("7effeba1-5e4e-4e20-b3b3-e472b9aaca4e"), 4, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("f226f502-90f2-4a7b-acb5-7b606c7f21f4"), 3, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("b8526d88-7a0a-4e48-9ffd-e1bd462ac328"), 2, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("6ef968fa-6cb5-4067-9c1e-d249089d839c"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("6f89a183-a722-4213-8a11-5b531862b52e"), 0, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 1 },
                    { new Guid("069b5517-66c5-48d4-a0cb-7e561eb65074"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("e3c31740-7c51-4cae-9390-85fa387a7557"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 0 },
                    { new Guid("110579ce-9dd3-4f14-a2ec-1b4fa7db186e"), 1, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 2 },
                    { new Guid("62db145b-0c4c-4f2b-882d-5fce3d8f474a"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 5 },
                    { new Guid("91726139-8ce9-4263-b4ab-bc54b2166387"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("615b89ee-a87f-4f48-b465-45dd121690d6"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("85f29060-3022-45ba-b0e9-521875550824"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("c0a1fad6-c088-4915-a84c-a50d264c130e"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("48252c73-f8aa-4aed-85f5-91dfe1bcb453"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("b61377cc-f5f1-4a58-bab2-a635e41d3abe"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("1ef62ab0-b7ce-4cfe-b430-05077bc1a6fb"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("c898b811-3f36-4e72-ad12-0ddd05688669"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("2449af95-dc42-4303-a20d-8bf7e42f17ed"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("8ef323fd-e32b-4328-8c0d-5448cd340f14"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("c957e8fa-aeb6-4bd2-bfe4-b7d8f3e4cca9"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("ba56abc0-9ca3-4c02-8db0-1d31f8dbfc06"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("7ebf701c-e8e3-4f82-9778-8f942b849dde"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 8 },
                    { new Guid("e4308124-7762-461f-8255-4b442cdfb4b7"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("a57f97d9-81ff-43c8-80c5-1400f838516e"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("55f14e13-4c79-4675-bae0-745262e5e0cc"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("39810e0b-09e4-4e3d-9b04-54e1270e51fc"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("e92b7f02-3b1c-4c46-976d-56b3d67ac43e"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("24953d50-25e0-45e4-a000-e316de815410"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("47d18526-d9ea-4228-8085-bcef27fce742"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("05023514-0e79-4c1e-b4c0-0fc59b8c56ca"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("052c4bd4-6690-4acd-940e-73f284bbea6f"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("2e0b6d30-b8fd-469a-8006-44f0d50c48ef"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 7 },
                    { new Guid("1f0227b7-9620-4b3b-a81c-60a5975abe23"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("6e73cc2f-6956-4d9f-b9a3-6e7586700b60"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("466b3104-d295-452b-a5f8-78186e5dcc75"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("4d274653-1cbf-44ab-9093-62a6ef2cdd54"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("2c9bbe6d-e2e9-4213-9e48-0cd2c4b1b95e"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("bff940be-5e27-4369-80c3-27ce9284a304"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("75607029-8044-400a-ad37-23c7c9cd4a5e"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("0b1b3342-c474-4a4e-9333-3b02ecf474bd"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("063df1de-ce35-4e0c-b4fe-b1f8c1878445"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("ead6fc86-10ff-4dc1-8b59-a097ab5f72d8"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("6fe8970e-a425-48e0-af5d-36ac67ffd589"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("8c874770-143f-4684-9ae4-52677fa14ecd"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("ae82845a-b50a-4969-9998-f9c396a82c22"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("5fddf61f-8bfd-4194-9d2c-831cc01e97b4"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("c6d26b17-45d3-4ae7-8a06-4a6fb4b77a35"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("66c06e61-bddf-48b2-b7c7-e5ee6ab49a69"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("ab260ef9-bc47-4d03-9b3e-1946b78dcded"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("6f48343d-6b80-49b0-bb6f-c123a8c1d0c2"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("91e8e3d6-a00b-4f85-855d-64f5acf42691"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("157b93fa-a7c2-4e78-b0b3-66d11e4f772f"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("27978aaf-f173-47bf-b593-c661a83863bb"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("7bab8216-401f-40ce-a0bd-9cc76c20ca91"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 1 },
                    { new Guid("416cfa6c-9b90-42cf-b12c-8237e293f093"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("25188a61-6cca-43d2-9653-ee6f1c323ee1"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("45b47673-b8ea-4d3f-a53a-7f158a2736b2"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("1f0d0057-6948-49c7-bc73-0b5575d97156"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("0234b224-2ba8-48c3-b79d-c38daef36c6d"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("7917da0a-93b2-4941-871f-e6efebe4f35e"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("6f295288-c072-404b-b1f7-175e1a52afad"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("feb7d9b0-6381-455d-9ecd-3998d2fea255"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("3a835591-9326-4368-9c6d-ea4620b95354"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("66407f54-cdaf-49df-abad-00fae0b520f2"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 0 },
                    { new Guid("e45d710a-f957-4393-a5ba-da777bcdf575"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("0b37d0aa-e3be-4ec6-a872-f5c1bcc7ef45"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("76716319-c9d4-456a-9340-c52760021455"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("8bc69119-c682-403d-8e84-812dcb4016e6"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("1febb835-ad91-45d6-9741-9d9d2412deed"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("a84dff4e-c017-48c3-ab6e-c73d41b96bbe"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 9 },
                    { new Guid("bbf488b5-b5ba-4826-84b3-42f33c3ebb67"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("77b24ab0-322c-4bb0-89ff-7e86255a7ca6"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("f742c194-efe3-40e1-b62d-66e3cfcaac87"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 6 },
                    { new Guid("d138eb0a-c1b3-4e31-83c1-13c3bdfb1103"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("3200bfc2-9262-4c69-9c2c-ebe58b5ab302"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("49c8713c-3992-4661-b41c-f6377b863cc7"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("0c87ce96-de69-4cb5-a843-df87af2799f3"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("0bdae96d-a267-4680-9902-366af14261db"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("e07f2f55-9074-4d1e-840d-3563b50b2f38"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("2d9cb62f-d739-4517-9a22-bf120c154f9d"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("f9c3782e-2460-438c-8398-5e708ffdd6b2"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("a59d3e62-d259-4b5d-860b-5a87ab4c888b"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("30a111c6-083b-40a3-94fe-73e59748c828"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("39b3a7ca-c62a-4f3b-9847-450cd02db79c"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("9d57d234-0e76-4c56-84d4-369deb458f95"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("15b2f22d-7af9-4ce9-8ebd-55800461bc23"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("2718e049-c01d-486e-9523-4853a44adc1c"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("362511ea-c101-473f-8ac9-bd7335674105"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("522b78de-8e43-406a-9b8f-be90a47c5aba"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("3edb4906-d3dd-4174-ab73-7abddf0fa07e"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("6fbfac47-4e5e-415b-908c-b6fede96b632"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 1 },
                    { new Guid("ee6a6d4d-ecce-4a53-957e-3436dbab2acb"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("c8df13c4-ded3-4e83-b0b9-f41906874280"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("b169c8d7-eb9e-4959-b514-826227602361"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("ed93a9ec-5f88-4458-8c83-e53a7600118a"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("74b693f1-8dc9-4db0-b060-c7669f37e6cf"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("2d5dc233-d340-49f6-b0dc-11df8a200336"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("f60b5f1e-c60d-416b-a745-775a0a848ce4"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("0176e390-f688-4515-b1b0-7cd89cc50d70"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("760d67ca-2596-4cb0-bb4f-6fddd6a4c5dd"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 0 },
                    { new Guid("42862c40-4580-43d0-8b36-20c7ccc2ec88"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("5f445482-de6e-42ac-a936-c953cba52869"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 2 },
                    { new Guid("4c7d6de3-156e-4a8c-a951-01a7e421a405"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("66493857-8247-4d69-a8ec-e195a2865980"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("0969a315-b48e-4030-a004-35c995d0489c"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("91cc4d68-e160-4d97-bd28-93953ab5f10e"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("dc658f75-b94b-4b90-bc04-9f2247e3dd76"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("b9871724-04b1-4014-a532-c2fda70fee89"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("25055b05-14d2-4ca8-ad30-a0eb09920d56"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("63d29c78-f461-4ef5-ae95-c58dd0b166e6"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("aae7edf0-8266-4355-9bf3-ee30350966b4"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("a14ee040-1757-4773-8bfc-c9bcd6330454"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("a0ddaf02-852c-457d-a7d9-8734382079ad"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("682b830e-1e66-45f6-a37f-6041a5a56b6c"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 5 },
                    { new Guid("ab7cfbab-87f3-4be3-8cf8-30c64e6a2321"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("c8dccee5-63f3-4046-990a-2f9d21523c7c"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("06511a5f-2bb8-4ed2-9b0b-24eb6de6dc4b"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("94936a2b-18ca-44b7-969b-921acfda087f"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("69a53869-11af-49d1-b3e8-22bd3d69bf3b"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("1bba6ef3-145c-46dc-9c61-cc216c4e7557"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("12c668e8-be41-4a03-a5cd-960f1fe6eddc"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("9d4f6531-f972-4511-809b-f570e52edfa5"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("afbccade-8d89-4280-a0f0-c50c1e162dfc"), 1, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("991e3b04-081e-4dfa-bd9f-fd9c77b5fb15"), 0, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("3596fd4b-be0f-492e-b721-f8ea21ccda5d"), 9, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("ad3c491a-39e9-4470-aab7-e08aebd2c3c1"), 8, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("4e61b5b9-9db1-4401-9c0e-12607460f3fe"), 7, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("1658aeee-c43f-4009-a190-2b55715f6f75"), 6, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("031c8a21-cdb5-475e-b3a5-923090b980a2"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("2b4e5ff0-5b81-48de-ae98-9f3415840310"), 4, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("713d839f-a16c-42d5-b29d-8e4ebfd508db"), 3, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("cf9d358b-c2c6-42fe-95d8-17a0ab272367"), 2, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 3 },
                    { new Guid("021911ae-3c80-4172-8c8c-fdecac04adc5"), 5, new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"), 4 },
                    { new Guid("8cf24989-1128-4ea7-a941-3b2b2a0c6f27"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("debf5380-bdeb-47a2-bc31-c6825da0f768"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("55146817-ac4e-4703-bf85-37800b3a9f90"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("84df636d-83cb-4501-9fa4-35320d3e7bc9"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("7c68e8b2-e0dd-4bb7-ad6f-47e1d67bfa8c"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("e5e261d9-2fe4-4199-8c12-4848a6cde066"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("b1cf8ba7-383b-4b6f-ac92-9f3abcacc007"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("78da7334-d2f1-495a-bbe4-7aacb23122df"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("940ffde8-d13f-41e4-acbe-d5bab85bbd38"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("8d55644c-eff3-40b6-8052-08c468a08162"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("3839d535-b5d8-45f6-8a1c-17dd6f59a182"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("83622e49-023f-42be-a43e-38818ebf4199"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("3b6ffe37-768d-479b-8c50-99d0970c7db0"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("e30a9f6c-19e4-4a3b-ad3d-297a248caaf5"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("492365d0-e7f4-451b-bef8-973cfeb9d5f6"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("fee4b7d6-09d7-4141-8a60-fa43a1310f0b"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("55e8c32b-78a2-4c72-adee-91eb6c3c3ec3"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("7f43c082-058a-48b2-a75f-52e465f409d7"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("0f94692a-8467-4447-ba93-c9f2345cef61"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 0 },
                    { new Guid("a7b86330-1625-4df8-84a5-754698e3d696"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("97302ec6-919f-4f16-ae53-44893b2a8146"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("ef97f57b-61a8-4415-a8d4-1283d9d811d8"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("1260711c-e2c2-4159-8423-02d0e28bcf69"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("d0b8ac8c-f2c8-4cf1-8695-3d6cadb5f715"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("de7cbc3e-767b-4f6a-8014-1f27557e42cd"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("62345e70-3c44-4ba3-b44a-dce98319ca98"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("2b066fde-610a-4e5f-9047-817968f6eb80"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("a63120e1-015e-42d4-ab0b-27a20a066b15"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("0c7425d6-71b4-4c7d-87d8-0a54e969cc8b"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 9 },
                    { new Guid("89dba7d7-01b2-41b6-9e43-27c63da9584b"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("790cabc5-389c-4b1f-9c17-06f95c457500"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("9b6f428d-42d0-4cde-8002-3e4249cd933f"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("4c3c0a0c-a932-4d52-b6f7-0a47a0aab9f9"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("fd87ed47-17c0-4502-91e6-8a084b97ead2"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 1 },
                    { new Guid("4c626663-d30a-47e3-b0d7-4ebcfe09160e"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("e25d0a4c-d0e9-4373-9f62-cd2414b4fa68"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("5730f9ee-37ab-4a1f-bcf7-8dfed114b58f"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("c0f62ffa-708d-4325-9b7b-c386e3b40847"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("141c0687-144e-4de3-9b17-512de197bc55"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("13c10950-1f08-4827-8146-c594c1e1b3d4"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("72124f74-6229-4f73-ae80-85fd650a7ebf"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("561ee412-818a-4e09-9256-b83e59016e93"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 4 },
                    { new Guid("cd02faed-b19b-41ca-866d-97c01dfa1b52"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("502b2516-52d0-4465-ac41-8451b06ddf0c"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("9a01ee2f-07da-427f-ac17-5f119f1e2a7f"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("d3a201de-a071-41eb-abf3-562ef122fe7d"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("dc71d097-d530-485d-8312-8b81c9389163"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("f7dd3917-f2cd-4837-8953-ef68cc9d8075"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("8e5a9cf7-bbf1-471a-bfc5-9e4ee4c1129e"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("c1a61dc1-f7ff-448f-be91-67085618af43"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("794b884c-59a2-4108-b800-17d80b182da1"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("509d5df9-4d43-4eb7-87cc-6630b46b57b2"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("018b6f95-a799-4782-864f-9fe28e8ca0b2"), 9, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("eb09e1d7-f8d5-43c7-9dda-e9dc01e38590"), 8, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("b52e32d2-a11f-4ffe-93db-85e398b9a8a8"), 7, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("dfbe98b1-11dd-4eb7-99c2-6f73c719c386"), 6, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("66bfa5c2-73ab-4e49-ac52-6e79504886d2"), 5, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("2decd866-4396-4b10-bf7c-fec769864e19"), 4, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("18bd098f-3eac-4bfe-beda-9e27b30b6d0b"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("3ef4cedc-b7f9-4d1d-8676-6322d61be733"), 2, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("fd39e29f-edaf-4763-b611-bb7f4ad229e4"), 1, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("44113048-b7cd-491a-ae08-7252906e1ec1"), 0, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 2 },
                    { new Guid("92d1ff80-74ca-49e6-9821-d2a913684100"), 3, new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"), 3 },
                    { new Guid("0da3fce3-0f04-47ee-a207-d0acdd297aec"), 8, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 },
                    { new Guid("550f7e06-c8a2-4cb0-95c6-4fa7f27ab097"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("c94c60d1-9d49-46fd-b3cd-789e136cf56c"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("c0eb88b7-2060-4444-b2ad-581e3ded0b32"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("7bb7052e-5e9f-46ed-aaae-b5be8d01f230"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("56e0bc04-d2fa-40b9-9560-993ca4d0a31f"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("5680127a-df05-4a07-b794-64f0cf315699"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("53e33d4e-ab2c-460b-acbe-c2f1bbc4b5ac"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("cd715971-d10a-40a2-a430-dae969a541d1"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("a355b177-a736-44ed-b772-5992a429834c"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("bc5160f9-86b0-4177-b1e5-c398eb6d93f0"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("38c9438e-954f-4462-87bd-6619f06503a4"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("1732cecb-e1f5-4e10-a931-f1a592a80215"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("b592611d-8966-404e-b668-f1fb6019a659"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("3d994dfb-98e9-477d-a463-0fa3becfa456"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("e66757af-85c7-4127-be0d-f8a8e0d5df10"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 4 },
                    { new Guid("6b635bb8-b304-4b78-9028-ed0d665c404e"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("3cf8f6e2-5486-490b-9435-306174e4d968"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("23e52126-4b17-48de-964f-ee4e35e92fe0"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("ec19ad06-1499-447a-bb51-bdb57ca27d27"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("a024d51a-f56a-4116-999d-9b56261f11ca"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("80727d9a-46a0-46ac-ae3d-4590ef68cd8d"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("bde28192-8377-47a2-b15a-77393d004298"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("1278ad94-a77b-4f6e-92a0-c2a7dcb5f4b7"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("ea01d1ac-8dfa-4693-baa1-c78fed687d11"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("4cc348df-10d2-4b3a-9370-778594b9f601"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 3 },
                    { new Guid("4b45cd6b-3e63-4a34-a5a9-b67f42f65c7c"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("2d28c6c2-72f2-4f78-82ac-e02df0c92638"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("5053fc1a-c4ac-4822-8118-311d79c5f8ab"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("55479549-30d6-4910-826a-36f95d656537"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 2 },
                    { new Guid("1e52048f-3351-4318-907d-ccf5e81355a2"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("97677d57-e2c7-441a-ab36-ab45d41e7e59"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("070f7e2f-6446-4150-8d42-5218a3c03134"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("291c4ea2-0814-425c-b6b4-6973199afea2"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("0ed8594e-accb-4cd1-810c-0476e6e23781"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("f915124e-5c06-41fd-9c70-9348f2cbbf4a"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("d82184bc-faa0-45d9-874d-57237ffb5b13"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("a6e2e654-0ad4-4600-9894-3b75be183375"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("20b687cb-2321-4582-bb59-319ba5b42cab"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("e2c6e5a5-afb6-42f1-9f41-f5f8af34ef17"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("406b6cbd-4a43-4460-a390-ad57214e2f76"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("e1873e84-07cf-4711-bf9e-8778b7b9f2ac"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("4a5ab705-029a-414f-b134-ba0be7717426"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("d0a6974b-c761-472b-9c1d-d08e3625aaec"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("4bdcbdea-2c4b-492a-86a0-cc1f4ebcccda"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("1fb955f3-b6da-45a8-be60-5c924f796058"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("b4373faf-95fc-449f-b3a3-4f08088b548b"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("dcf3d6e2-7f7f-4f2b-a266-481e8c9f2254"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 8 },
                    { new Guid("f0b4b69e-68aa-4f12-b4a8-093ed52efcec"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("cc1c2c2a-ea05-4706-b3d4-346651cb0f39"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("3d69d06e-f187-438e-98ef-c878de270e8c"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("32be5468-c4fc-4f60-9539-21c390568c8c"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("0b224c96-3f41-4540-9388-6b5de21480be"), 6, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("b10b157c-23e6-4032-8183-afa0f4cbaf47"), 5, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("2d49323d-6830-4947-8b5d-49b48abcf608"), 4, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("f936997b-9d66-4d76-84d3-7ae20b348c35"), 3, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("2026be7e-b498-4ef1-a45a-8d53c1a34786"), 2, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("35fce2cf-66c1-4a13-b238-7ce9b83f9057"), 1, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("78abb4cf-7091-400d-a58b-2fc40146104a"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 6 },
                    { new Guid("cfbf132d-6ce0-4e0e-9f6c-e6fc97223085"), 9, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("41fcc741-c8c8-4989-af45-0b180bb5e0fb"), 8, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("66beb9bb-079f-4a5b-a894-af4f129ab9f3"), 7, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 5 },
                    { new Guid("21f55a0d-c1bb-4514-aa96-bce09b5428f2"), 0, new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"), 7 },
                    { new Guid("b3e86ec7-c52f-48a4-bf8e-d7ee1c085ec7"), 9, new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"), 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("009394a3-8d5c-4b9c-b848-61487ccc7ec0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("00e88f99-3741-4b65-b83f-841765404716"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0176e390-f688-4515-b1b0-7cd89cc50d70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("018b6f95-a799-4782-864f-9fe28e8ca0b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01e5432f-6b6c-4acc-a92f-acce342f6588"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("01f6b10b-2f51-4d02-a602-627554f8961e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("021911ae-3c80-4172-8c8c-fdecac04adc5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0234b224-2ba8-48c3-b79d-c38daef36c6d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("031c8a21-cdb5-475e-b3a5-923090b980a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("03cadd92-a050-4b77-addc-8a60887506c9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0422c05c-7267-40cf-9187-51591ec9f8dc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("04c1d8eb-248c-4e0b-92e4-899c75124317"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("05023514-0e79-4c1e-b4c0-0fc59b8c56ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("052c4bd4-6690-4acd-940e-73f284bbea6f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06146bed-d7ef-4a9c-8f54-091d2be5528d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("063df1de-ce35-4e0c-b4fe-b1f8c1878445"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06511a5f-2bb8-4ed2-9b0b-24eb6de6dc4b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("069b5517-66c5-48d4-a0cb-7e561eb65074"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("070f7e2f-6446-4150-8d42-5218a3c03134"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09011512-f37f-4b06-a462-70efc50dd30f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0969a315-b48e-4030-a004-35c995d0489c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09acd0a4-480e-4b2d-90d4-5b1d971a02db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09ad1b5e-6562-4332-aa57-3e79da1bd1ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09ded0fe-6699-469f-941d-a4be7749b8e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("09f1e613-1732-43ec-9673-e51638078444"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0aa08517-ffbb-4bec-be33-675d02dae2ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b1b3342-c474-4a4e-9333-3b02ecf474bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b224c96-3f41-4540-9388-6b5de21480be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b37d0aa-e3be-4ec6-a872-f5c1bcc7ef45"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0b6a2f61-6ff3-43dc-99ae-7e2f78ecba9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bdae96d-a267-4680-9902-366af14261db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0be650b2-507c-4212-aa43-7e8832eb7cb5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0bfbeac4-8d64-4b65-a89b-82d8659ec051"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c7425d6-71b4-4c7d-87d8-0a54e969cc8b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0c87ce96-de69-4cb5-a843-df87af2799f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0cda7845-bd78-478e-8b99-198a7071470c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0d358955-f329-40e2-986b-3d92bbc6fe3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0da3fce3-0f04-47ee-a207-d0acdd297aec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0dc66719-2348-4ad8-b4fe-b92fe50b8de8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0e1ff835-5e5e-4a6f-b28c-9e8c0f71d0e9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0ed8594e-accb-4cd1-810c-0476e6e23781"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("0f94692a-8467-4447-ba93-c9f2345cef61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("10974b12-85f9-420f-859c-e4a113f55881"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("110579ce-9dd3-4f14-a2ec-1b4fa7db186e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("11065b30-bcdf-4732-bf3d-413aa6faca3c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("122c0d5f-3356-484f-aa08-894d2a5483b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1260711c-e2c2-4159-8423-02d0e28bcf69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1278ad94-a77b-4f6e-92a0-c2a7dcb5f4b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1299891d-74cc-4967-9b01-b516ef6bd3bd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("12c668e8-be41-4a03-a5cd-960f1fe6eddc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("13c10950-1f08-4827-8146-c594c1e1b3d4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("14094ae3-56d7-414d-8891-21ddf9c43255"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("141c0687-144e-4de3-9b17-512de197bc55"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("157b93fa-a7c2-4e78-b0b3-66d11e4f772f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15b2f22d-7af9-4ce9-8ebd-55800461bc23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1658aeee-c43f-4009-a190-2b55715f6f75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("16ebd77e-45b7-4648-a45a-b4bf952b6669"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1732cecb-e1f5-4e10-a931-f1a592a80215"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17763cb4-9e4b-4ea4-b529-35e0c960a2e2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("17d10c29-4cd3-4fe4-8b52-11f904e5838a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18bd098f-3eac-4bfe-beda-9e27b30b6d0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("18da086b-2a1d-4cbe-8cd2-343ede0e68c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1aa0a0ae-c8db-438b-8871-511b293e1cae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1bba6ef3-145c-46dc-9c61-cc216c4e7557"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1dbc0e30-844d-42d8-9cfe-c357f75d9aaa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1e52048f-3351-4318-907d-ccf5e81355a2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1ef62ab0-b7ce-4cfe-b430-05077bc1a6fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f0227b7-9620-4b3b-a81c-60a5975abe23"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f0d0057-6948-49c7-bc73-0b5575d97156"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1f4b2168-cd5a-4d6e-9a1f-9171f76de3c8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1fb955f3-b6da-45a8-be60-5c924f796058"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1fcf077e-796a-4b4e-9d8b-794a5815db0b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1febb835-ad91-45d6-9741-9d9d2412deed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2026be7e-b498-4ef1-a45a-8d53c1a34786"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("20b687cb-2321-4582-bb59-319ba5b42cab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("218e17f5-a56d-4c68-9665-16ec93bb9170"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("21f55a0d-c1bb-4514-aa96-bce09b5428f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("22ac6fab-647b-4673-ae25-2f9012b58180"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23e52126-4b17-48de-964f-ee4e35e92fe0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2449af95-dc42-4303-a20d-8bf7e42f17ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("24953d50-25e0-45e4-a000-e316de815410"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25055b05-14d2-4ca8-ad30-a0eb09920d56"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("25188a61-6cca-43d2-9653-ee6f1c323ee1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("26274ee7-045d-4915-a24e-d11499a5e84f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2718e049-c01d-486e-9523-4853a44adc1c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2769bbd0-923f-41b9-9022-f24db6c0f04c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("27978aaf-f173-47bf-b593-c661a83863bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("28dd7242-dad0-4100-a886-32db1eb0dea3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("291c4ea2-0814-425c-b6b4-6973199afea2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2a662451-5cd6-41c6-b24b-94177247cd37"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b066fde-610a-4e5f-9047-817968f6eb80"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2b4e5ff0-5b81-48de-ae98-9f3415840310"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2bac45dc-e101-4cd8-afaa-ff79c23f7692"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c28bc3d-df77-4374-b4e8-25d1df447a61"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2c9bbe6d-e2e9-4213-9e48-0cd2c4b1b95e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2cd8e0d2-0bf0-44d7-a7e5-a5de4e529f70"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d280ff8-ad74-4b76-bb4b-ff7a3b292d9a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d28c6c2-72f2-4f78-82ac-e02df0c92638"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d49323d-6830-4947-8b5d-49b48abcf608"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d5dc233-d340-49f6-b0dc-11df8a200336"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2d9cb62f-d739-4517-9a22-bf120c154f9d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2decd866-4396-4b10-bf7c-fec769864e19"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2e0b6d30-b8fd-469a-8006-44f0d50c48ef"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("2ff6f02e-f560-4413-87ba-6f3b9fa4338c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("30a111c6-083b-40a3-94fe-73e59748c828"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3200bfc2-9262-4c69-9c2c-ebe58b5ab302"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3293d8bb-31f0-4a87-ac83-c81bfacbd5fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32be5468-c4fc-4f60-9539-21c390568c8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("32d1e10b-8d63-470b-9395-cfb4e3a53b03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3596fd4b-be0f-492e-b721-f8ea21ccda5d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("35fce2cf-66c1-4a13-b238-7ce9b83f9057"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("362511ea-c101-473f-8ac9-bd7335674105"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3793922d-8580-4dae-8b13-c2dae60d90c6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37a731ba-1d5a-4b87-bce9-0c47f39d8a5d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37e39705-9fd1-4942-a8f9-395166d0a090"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("382989bc-73b4-4f1a-a37f-95c0d5a4c052"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3839d535-b5d8-45f6-8a1c-17dd6f59a182"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("38c9438e-954f-4462-87bd-6619f06503a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39810e0b-09e4-4e3d-9b04-54e1270e51fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39b3a7ca-c62a-4f3b-9847-450cd02db79c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("39ccdf45-4a6c-4587-bfd9-b8d1f9121fcb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3a835591-9326-4368-9c6d-ea4620b95354"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ad09cd9-4ff7-407e-9df2-d2dd0696a4ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b2a1be2-87eb-4c16-9f59-5e8125a273e5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3b6ffe37-768d-479b-8c50-99d0970c7db0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3cf8f6e2-5486-490b-9435-306174e4d968"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d69d06e-f187-438e-98ef-c878de270e8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3d994dfb-98e9-477d-a463-0fa3becfa456"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3e96720b-f44a-489e-aba2-24cb26902a2d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3edb4906-d3dd-4174-ab73-7abddf0fa07e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("3ef4cedc-b7f9-4d1d-8676-6322d61be733"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("406b6cbd-4a43-4460-a390-ad57214e2f76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40b239c2-0525-4261-9538-8ed165fb250e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40cfd45d-79ed-479d-acc7-788a62c17158"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("40ff88ad-a447-4603-8d15-6dbfe11ece9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("416cfa6c-9b90-42cf-b12c-8237e293f093"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("41fcc741-c8c8-4989-af45-0b180bb5e0fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42862c40-4580-43d0-8b36-20c7ccc2ec88"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("42f5ccb5-d592-4e74-99db-106eb9a1f696"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4345ded7-c2c8-4e66-8abd-b03e554494f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("43e6dfa0-38b7-49db-a200-1f2fd001d616"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44113048-b7cd-491a-ae08-7252906e1ec1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44801577-2140-40ec-bec1-2ce799f81f32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("44c0e039-2330-4b23-8532-bfc7ab150973"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4560a07c-1f9e-4246-826f-6f00a7adb1c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("45b47673-b8ea-4d3f-a53a-7f158a2736b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("466b3104-d295-452b-a5f8-78186e5dcc75"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("47d18526-d9ea-4228-8085-bcef27fce742"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("48252c73-f8aa-4aed-85f5-91dfe1bcb453"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("488a4c66-2b3a-429a-9761-7697d24815a7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("492365d0-e7f4-451b-bef8-973cfeb9d5f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49c6d5e5-3b71-4281-8107-3201b09a7f55"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49c8713c-3992-4661-b41c-f6377b863cc7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("49fef3e0-9ea9-4717-9495-9e4e79c1b97f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4a5ab705-029a-414f-b134-ba0be7717426"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4b45cd6b-3e63-4a34-a5a9-b67f42f65c7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bdcbdea-2c4b-492a-86a0-cc1f4ebcccda"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4bf5c364-eb8f-41bb-bdb3-e46e2b95db65"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c3c0a0c-a932-4d52-b6f7-0a47a0aab9f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c626663-d30a-47e3-b0d7-4ebcfe09160e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4c7d6de3-156e-4a8c-a951-01a7e421a405"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ca8fc01-302c-4fb0-a70c-09eda626983e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cc348df-10d2-4b3a-9370-778594b9f601"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4cc7d28d-6d07-4170-b195-c216c496bf6c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d274653-1cbf-44ab-9093-62a6ef2cdd54"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4d5cc8bd-b087-418a-959d-4bc787f34aa5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4e61b5b9-9db1-4401-9c0e-12607460f3fe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ee373ad-cccd-465a-a636-cdd644414ec7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4ef278ad-0741-4a9d-91b3-856cf9d2ee25"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4f95ca57-7c97-4587-9cec-7ef024382882"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fb006c0-636f-44a0-ac1c-277ba8f271f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4fdd9945-5b33-4a09-8a7a-af3ca8bc910a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("502b2516-52d0-4465-ac41-8451b06ddf0c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5053fc1a-c4ac-4822-8118-311d79c5f8ab"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("509d5df9-4d43-4eb7-87cc-6630b46b57b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("50b3a33d-fb27-4c89-8603-ac9ef6e7cc8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("511e0a64-5133-4a9a-a128-143ae3effc3c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("51f53d0d-8f65-4c37-8261-7749da114fb2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("522b78de-8e43-406a-9b8f-be90a47c5aba"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5239d9bb-2f7f-4d33-a6d3-19a11c1f25d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5298bb68-1b90-4c34-949f-abcecc2db6d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("539c3739-23f7-407a-a99e-63ec445596fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53d997a1-1ddc-4fdf-9834-c3f53d5be707"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("53e33d4e-ab2c-460b-acbe-c2f1bbc4b5ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("54272068-03d0-4779-9b36-ab837f5c8dd7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("550f7e06-c8a2-4cb0-95c6-4fa7f27ab097"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55146817-ac4e-4703-bf85-37800b3a9f90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55479549-30d6-4910-826a-36f95d656537"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("557d1d0f-b52b-47ea-bec3-e6052f4bd4ed"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("558b4f57-229d-480b-89c4-e50f954910de"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55e8c32b-78a2-4c72-adee-91eb6c3c3ec3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("55f14e13-4c79-4675-bae0-745262e5e0cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("561ee412-818a-4e09-9256-b83e59016e93"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5680127a-df05-4a07-b794-64f0cf315699"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("56829324-c0ca-4b4d-960c-35e7d08c4a97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("56bb9cb2-ed1b-4e9a-a83d-5c11ece5a09d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("56e0bc04-d2fa-40b9-9560-993ca4d0a31f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5730f9ee-37ab-4a1f-bcf7-8dfed114b58f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("59633c3a-4498-4259-b815-0b824aa86885"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b253db5-c34e-4fb9-82fe-348b08284b34"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5b815a1c-708e-412a-a477-7527dbbd8a92"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5be67098-edd7-4541-b4a2-c4c9244257eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5eb1d0c4-8f00-4f4a-87bb-a68b7b246cdd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f445482-de6e-42ac-a936-c953cba52869"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5fddf61f-8bfd-4194-9d2c-831cc01e97b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60163fc7-f1bb-453a-845f-d98b5772c70c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("60391eb3-ee7c-4d1c-ac4f-7b45ce0a277f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("615b89ee-a87f-4f48-b465-45dd121690d6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62345e70-3c44-4ba3-b44a-dce98319ca98"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("62db145b-0c4c-4f2b-882d-5fce3d8f474a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("637ff249-3f4d-4eae-a7c4-f3ecbea28661"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("63d29c78-f461-4ef5-ae95-c58dd0b166e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("650e0a38-47c3-4761-a6d4-d37dcf0d7893"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("651bed61-2ff1-4762-ad30-a61d99747e76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("656ea4de-0aff-49bf-8422-0962fe124610"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6617c5f8-85ac-4ebb-a825-ef0dc34edce7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66407f54-cdaf-49df-abad-00fae0b520f2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66493857-8247-4d69-a8ec-e195a2865980"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("667c189e-a164-4fba-a677-6181f1bc119d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6688e005-efdf-4cd9-a275-57b4ea5cc4f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66beb9bb-079f-4a5b-a894-af4f129ab9f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66bfa5c2-73ab-4e49-ac52-6e79504886d2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66c06e61-bddf-48b2-b7c7-e5ee6ab49a69"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66c79268-73e1-4ccb-83ad-b924b832fcb1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("68081bc5-caf5-4859-af03-34df4851209a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("682b830e-1e66-45f6-a37f-6041a5a56b6c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("68b0c9e7-f857-4b05-b7db-db5af6ea8a35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("69a53869-11af-49d1-b3e8-22bd3d69bf3b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b14194e-949b-4b03-a0a1-c602a1646038"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6b635bb8-b304-4b78-9028-ed0d665c404e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6bd0d8a2-e97e-4d41-9f8b-8fa6229205c6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ca2fda9-6047-4791-a4ec-50819dcfcf0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6cce6d76-a431-4698-bcff-01d7d403d494"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6d9b26fa-fa80-45ca-9b25-e189f9e15626"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6da36955-9ce7-4fbe-93bb-2b4bf4747a04"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6dbd21db-a7b4-4181-ac59-3944c66f31eb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6df32f8f-75ec-48b0-bb72-90d9013faaec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e73cc2f-6956-4d9f-b9a3-6e7586700b60"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6e98c15b-6d8a-43d6-9033-612579c107ce"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6ef968fa-6cb5-4067-9c1e-d249089d839c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f295288-c072-404b-b1f7-175e1a52afad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f48343d-6b80-49b0-bb6f-c123a8c1d0c2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6f89a183-a722-4213-8a11-5b531862b52e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fbfac47-4e5e-415b-908c-b6fede96b632"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fe8970e-a425-48e0-af5d-36ac67ffd589"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6fe92734-3c95-4f62-8ecf-bf7f6d6b560a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7130adbc-003b-4df0-af86-d296c605ff64"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("713d839f-a16c-42d5-b29d-8e4ebfd508db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72124f74-6229-4f73-ae80-85fd650a7ebf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72f83749-1d7b-47c5-acf2-f4822a7691b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7350a01a-9fd4-4d14-a96d-206239125767"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73b5f725-93ad-4760-9663-05ca2f5facf2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("73d74b45-1417-4ef6-98e0-3617fbb813b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("74b693f1-8dc9-4db0-b060-c7669f37e6cf"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75607029-8044-400a-ad37-23c7c9cd4a5e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("75d1e7c7-65e9-4a0c-91b7-4cf0165045f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("760d67ca-2596-4cb0-bb4f-6fddd6a4c5dd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76716319-c9d4-456a-9340-c52760021455"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("767e0f99-9d3c-418a-b128-b51f685f0475"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("76a7f9d2-c1d8-45ac-a2e5-ac37e9a3f394"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7789f3fd-6845-4cda-a26a-5a51c33cd332"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77b24ab0-322c-4bb0-89ff-7e86255a7ca6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("77dd6473-a57a-484f-9c1e-2dcb0db45c0f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78abb4cf-7091-400d-a58b-2fc40146104a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("78da7334-d2f1-495a-bbe4-7aacb23122df"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("790cabc5-389c-4b1f-9c17-06f95c457500"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7917da0a-93b2-4941-871f-e6efebe4f35e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("794b884c-59a2-4108-b800-17d80b182da1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7bab8216-401f-40ce-a0bd-9cc76c20ca91"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7bb7052e-5e9f-46ed-aaae-b5be8d01f230"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7c68e8b2-e0dd-4bb7-ad6f-47e1d67bfa8c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ebf701c-e8e3-4f82-9778-8f942b849dde"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ecfe9ce-8615-4cc8-a977-1301da584d6c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7effeba1-5e4e-4e20-b3b3-e472b9aaca4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f214471-0899-439b-9b3a-e6b5f2e7f3fc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f43c082-058a-48b2-a75f-52e465f409d7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7f5b8647-ea8a-463d-9c69-29f192704b99"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("800e3ef1-430b-4127-b097-1c28b931b002"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80727d9a-46a0-46ac-ae3d-4590ef68cd8d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("80d103cd-7af2-4253-a7db-7a6a139fd4ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81034dac-e856-4347-8050-2f92c701c543"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("81b9a7f4-4635-465b-af3d-c94449d34f21"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83622e49-023f-42be-a43e-38818ebf4199"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84a5581d-cb29-4449-b850-b1a1120bc29d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("84df636d-83cb-4501-9fa4-35320d3e7bc9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("85f29060-3022-45ba-b0e9-521875550824"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89008b72-0495-49de-b328-93d4b47e74fd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89dba7d7-01b2-41b6-9e43-27c63da9584b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8af6f3bf-9ed4-4c50-b6e2-479c1441c66f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8b0fee1b-d61b-4dbb-9b22-15a77bdedd07"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8bc69119-c682-403d-8e84-812dcb4016e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c79dd0b-71f4-4a93-8c4e-3c20e378a050"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8c874770-143f-4684-9ae4-52677fa14ecd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cf24989-1128-4ea7-a941-3b2b2a0c6f27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8cf6bdfd-4c50-4667-a0fa-2434849be002"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d1fac2d-964c-48f5-b64b-645e4404e6ee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8d55644c-eff3-40b6-8052-08c468a08162"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8e5a9cf7-bbf1-471a-bfc5-9e4ee4c1129e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ef323fd-e32b-4328-8c0d-5448cd340f14"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8f1d05db-25eb-4e8e-a55d-6ae8997e2ef8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("8ffa7f61-8d3e-47b4-ab84-404d37c7fc0f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91726139-8ce9-4263-b4ab-bc54b2166387"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91cc4d68-e160-4d97-bd28-93953ab5f10e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("91e8e3d6-a00b-4f85-855d-64f5acf42691"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9242499b-724f-49cb-9171-3f38a5dec69b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("92d1ff80-74ca-49e6-9821-d2a913684100"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("940ffde8-d13f-41e4-acbe-d5bab85bbd38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("945fce00-cdff-4ecd-b036-1cb6e3306314"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("94936a2b-18ca-44b7-969b-921acfda087f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("95614c8a-61ad-467f-94bd-90532b031ac7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96861da4-882f-4b21-8cd6-84c4f43cf865"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("96a60f49-052d-45db-b052-21a6199b7570"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("972a5963-8313-4e74-9949-53fc9537f3ae"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("972e6a69-3428-4484-99cc-c183bea6b9d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97302ec6-919f-4f16-ae53-44893b2a8146"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("97677d57-e2c7-441a-ab36-ab45d41e7e59"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("991e3b04-081e-4dfa-bd9f-fd9c77b5fb15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("99873958-e3be-4961-93f6-1d03403b59e1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a01ee2f-07da-427f-ac17-5f119f1e2a7f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9a2661dd-b74c-4519-9b7b-3f1d353c5527"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b1c00eb-41b9-44c7-b6ad-8b269d06a127"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9b6f428d-42d0-4cde-8002-3e4249cd933f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c686e5f-5ba2-4eca-b7a7-cd6244ec2a03"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d4f6531-f972-4511-809b-f570e52edfa5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d57d234-0e76-4c56-84d4-369deb458f95"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9d9b40e8-324d-4e1a-98cb-1bef83deebc6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9e030dcf-58e5-4a48-99a7-9aab4ccffe0e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fb1ff22-6569-4524-9961-14d005aab8db"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a024d51a-f56a-4116-999d-9b56261f11ca"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a06f6145-29b2-4351-a14a-e14c076071b0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0ddaf02-852c-457d-a7d9-8734382079ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a14ee040-1757-4773-8bfc-c9bcd6330454"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a31b1f19-3634-4e07-88bc-4d7adb15c409"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a355b177-a736-44ed-b772-5992a429834c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a36f6923-bfd7-4081-87a6-cc296bcfd3ad"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4265d0e-2bc1-4853-82f5-0e2dde16de05"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a57f97d9-81ff-43c8-80c5-1400f838516e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a59d3e62-d259-4b5d-860b-5a87ab4c888b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a63120e1-015e-42d4-ab0b-27a20a066b15"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a6e2e654-0ad4-4600-9894-3b75be183375"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a7b86330-1625-4df8-84a5-754698e3d696"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a84dff4e-c017-48c3-ab6e-c73d41b96bbe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a8ecd724-763c-4a81-8c51-287c4624679f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a9aea3b3-33be-4e9b-9fd4-0d17f8469cc9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("aae7edf0-8266-4355-9bf3-ee30350966b4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab260ef9-bc47-4d03-9b3e-1946b78dcded"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ab7cfbab-87f3-4be3-8cf8-30c64e6a2321"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac298b2f-9fc6-410c-9c4a-997bf8d9344f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ac32d4d0-fe4b-4188-9492-44208b20f92e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad16bc50-4f2f-4ea7-a4cd-a87a1ee8de9e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad365313-cad2-40e9-beea-7bb78e14d7f6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ad3c491a-39e9-4470-aab7-e08aebd2c3c1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae766d31-5485-43af-8b28-dc910e6fc121"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ae82845a-b50a-4969-9998-f9c396a82c22"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afbccade-8d89-4280-a0f0-c50c1e162dfc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("afbdc4fb-13b8-46b2-aaa3-5575496a7983"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b0056fbb-139b-42ed-be49-46898d4155bb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b10b157c-23e6-4032-8183-afa0f4cbaf47"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b13cb0a7-af31-4849-afaf-06ad8856ef51"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b169c8d7-eb9e-4959-b514-826227602361"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1811042-50d4-43e5-91bd-bc373acd44e6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b1cf8ba7-383b-4b6f-ac92-9f3abcacc007"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b25664b3-79a4-4d69-89cd-03078748c82c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b350286e-ca3f-4c76-9ac6-8c39ea8eef53"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b3e86ec7-c52f-48a4-bf8e-d7ee1c085ec7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4373faf-95fc-449f-b3a3-4f08088b548b"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b476fdff-a187-4da9-9115-e149655d442f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b48f73b0-fce0-4a29-9cd2-198a4036b299"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b52e32d2-a11f-4ffe-93db-85e398b9a8a8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b56e24d0-a254-4ead-a0b3-276fb7d014d9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b592611d-8966-404e-b668-f1fb6019a659"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b61377cc-f5f1-4a58-bab2-a635e41d3abe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b78b8820-1516-4088-be7b-184514f8f56f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7be911f-c423-471d-b536-50add8c8922d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b7c3cb4c-6fef-411e-b96a-952aa1531062"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b8526d88-7a0a-4e48-9ffd-e1bd462ac328"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b97b31a9-d4a0-4a5c-8733-ab7c9b3a492f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b9871724-04b1-4014-a532-c2fda70fee89"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba23768b-fee9-4be8-acb9-0304cddc3609"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ba56abc0-9ca3-4c02-8db0-1d31f8dbfc06"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bbf488b5-b5ba-4826-84b3-42f33c3ebb67"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc5160f9-86b0-4177-b1e5-c398eb6d93f0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bc82cf70-a1ec-46d9-8fc8-5796d37fb49c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bde28192-8377-47a2-b15a-77393d004298"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("be5cb93b-9e7a-4c5a-bdbd-908e80b7a099"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("bff940be-5e27-4369-80c3-27ce9284a304"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0a1fad6-c088-4915-a84c-a50d264c130e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0eb88b7-2060-4444-b2ad-581e3ded0b32"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c0f62ffa-708d-4325-9b7b-c386e3b40847"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c1a61dc1-f7ff-448f-be91-67085618af43"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2da5c45-f0e4-46ed-b397-20625c0637cc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c2ebdc55-703e-42cf-8cee-4db0f6920590"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c435f25c-5c45-4238-b604-33672596441f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c499d32c-3f06-45ce-a41a-df09f752a5b9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c62239a3-3d1c-4d73-aa8e-a3031adaeebe"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c627c772-8715-40d5-8ad2-71ce6fd2711a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c6d26b17-45d3-4ae7-8a06-4a6fb4b77a35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c73b0bba-cf1d-4e83-b8b6-10795cad23d3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c761608f-0ec1-4b0d-af5e-8b505eb90a64"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c898b811-3f36-4e72-ad12-0ddd05688669"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8dccee5-63f3-4046-990a-2f9d21523c7c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8dda5c4-d70e-4d08-837f-9e963d2f7aa2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8df13c4-ded3-4e83-b0b9-f41906874280"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c94c60d1-9d49-46fd-b3cd-789e136cf56c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c957e8fa-aeb6-4bd2-bfe4-b7d8f3e4cca9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cabfbc7c-7c7e-4935-ba88-95f0c5b2ba93"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("caf8a03b-fa56-4227-8239-f5e155c12e68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cb06e201-494a-4732-9d2a-fdec20ab65be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cc1c2c2a-ea05-4706-b3d4-346651cb0f39"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ccc22e0d-2c30-4a31-9ae8-6c6a335a0509"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd02faed-b19b-41ca-866d-97c01dfa1b52"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd1b1661-697b-47ff-b0ad-49a262624094"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cd715971-d10a-40a2-a430-dae969a541d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ce039e9e-9e39-4d26-b834-d275045d2929"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf8adae5-b2b1-44ef-84e6-873005dce63e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cf9d358b-c2c6-42fe-95d8-17a0ab272367"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfaeecf5-7a0c-4016-9f7b-d8223503228a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("cfbf132d-6ce0-4e0e-9f6c-e6fc97223085"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0a6974b-c761-472b-9c1d-d08e3625aaec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d0b8ac8c-f2c8-4cf1-8695-3d6cadb5f715"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d138eb0a-c1b3-4e31-83c1-13c3bdfb1103"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d1460fee-37a9-4532-ba1e-fb989a79a76a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d23b4c2f-62b2-4541-afa3-953962bdfb76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2903645-f16f-4d9c-b0f7-47fc636cebee"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d2bbd1ce-d457-4ef9-b5f8-ce560413950f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d3a201de-a071-41eb-abf3-562ef122fe7d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d41ffd02-b4c6-40f7-9ca7-e6be84689703"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d64d6678-1a23-4051-a872-2c91b030dab5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d6ef232b-1a88-446c-a1f8-9d55ccc06970"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("d82184bc-faa0-45d9-874d-57237ffb5b13"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da16bf33-38a2-418c-932c-b0a1d5fcc149"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("da56b40a-7c82-46ce-9518-9c163c32c1f3"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dabc87a8-ad52-45e7-9f6d-214a235649bc"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("db14cbf9-8b73-4408-b7f9-f953bcce1a3f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc658f75-b94b-4b90-bc04-9f2247e3dd76"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dc71d097-d530-485d-8312-8b81c9389163"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dcf3d6e2-7f7f-4f2b-a266-481e8c9f2254"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dd5d68a6-7fc1-4923-98de-278fe24bdbf8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("de7cbc3e-767b-4f6a-8014-1f27557e42cd"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("debf5380-bdeb-47a2-bc31-c6825da0f768"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("dfbe98b1-11dd-4eb7-99c2-6f73c719c386"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e068ad93-4acc-48db-989d-f9e62e2e2938"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e07f2f55-9074-4d1e-840d-3563b50b2f38"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e118a847-a263-4151-87a6-737aece03215"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1672997-6644-457a-b96c-f91371f00b40"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1873e84-07cf-4711-bf9e-8778b7b9f2ac"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e1e7b0a4-30d0-40e9-ad5e-d64798b9a10c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e25d0a4c-d0e9-4373-9f62-cd2414b4fa68"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e2c6e5a5-afb6-42f1-9f41-f5f8af34ef17"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e30a9f6c-19e4-4a3b-ad3d-297a248caaf5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3bcb579-fa68-4887-9215-f3dbaa128b4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3c31740-7c51-4cae-9390-85fa387a7557"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e3d46bfc-8a73-4c4a-9ce2-a5bfab146e90"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4308124-7762-461f-8255-4b442cdfb4b7"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e45d710a-f957-4393-a5ba-da777bcdf575"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e4b76e72-4e2e-4008-9399-11ea7b6d53b8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e58bb543-dfbc-4b4d-b9f5-bf0d41add664"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e5e261d9-2fe4-4199-8c12-4848a6cde066"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e66757af-85c7-4127-be0d-f8a8e0d5df10"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e7942202-9522-4a97-9621-fcafd8433f0a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e869dbb4-1a10-47ce-a913-d30d94a83421"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e92b7f02-3b1c-4c46-976d-56b3d67ac43e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("e9d4d763-39e9-4fbc-8dd9-d6b8e46324f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea01d1ac-8dfa-4693-baa1-c78fed687d11"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ea719863-80b5-4966-9ff8-33094236205f"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ead6fc86-10ff-4dc1-8b59-a097ab5f72d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb09e1d7-f8d5-43c7-9dda-e9dc01e38590"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eb78cd71-b295-40b2-b65d-e281e91a1df1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ebf2c0e3-038d-4306-b472-027d52ff8587"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec19ad06-1499-447a-bb51-bdb57ca27d27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ec1db9a9-6fce-4222-b9f9-cafc0d5f70a4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ed93a9ec-5f88-4458-8c83-e53a7600118a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ee6a6d4d-ecce-4a53-957e-3436dbab2acb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eec08cce-ec39-4251-b59b-939d118bfb7a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("ef97f57b-61a8-4415-a8d4-1283d9d811d8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("efd266bd-b8c5-4c86-9b44-ae41b262b090"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0b4b69e-68aa-4f12-b4a8-093ed52efcec"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0c124c4-c8e7-4fbb-9044-9fbee3402ee0"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f0c4607d-418b-4289-9a9a-4d61b54c9f83"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f15e4c7a-3879-4e95-819e-1b42f73973d1"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f226f502-90f2-4a7b-acb5-7b606c7f21f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f292da0e-4b45-4361-b52d-2048bdfe7ec2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f29e1d6f-b71b-456f-ba96-d6d8928eb9fb"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f5ba77c8-e227-48e8-b3d3-40300f9c03f9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f60b5f1e-c60d-416b-a745-775a0a848ce4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f742c194-efe3-40e1-b62d-66e3cfcaac87"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f74cce81-d883-4e26-b6b2-7f76ff706139"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f7dd3917-f2cd-4837-8953-ef68cc9d8075"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f915124e-5c06-41fd-9c70-9348f2cbbf4a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f936997b-9d66-4d76-84d3-7ae20b348c35"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("f9c3782e-2460-438c-8398-5e708ffdd6b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fa608550-0523-447c-a542-56528b6e2d4e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fb81d59f-3f8a-4f77-aa10-7dfbdaedb407"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fbc71790-dc96-4fae-9a25-1cfb60226ba6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd39e29f-edaf-4763-b611-bb7f4ad229e4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fd87ed47-17c0-4502-91e6-8a084b97ead2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fe8f1583-182c-42cc-bb9c-213df80c5745"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("feb7d9b0-6381-455d-9ecd-3998d2fea255"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fedfc43b-a8f1-4988-8f16-674b91557647"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fee4b7d6-09d7-4141-8a60-fa43a1310f0b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1142c2e9-8da9-45fe-a0bb-621fa8790a87"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("128546fd-0347-469c-b8aa-0381aa2b1b3c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3a19ad61-56c3-4dbd-8667-9203226dd936"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("7a5d6a55-43e7-4925-afbb-fcd789b36356"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("f14ca44e-cff7-44c4-a77a-6a0d171d49e9"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: new Guid("2748aa24-9837-40a7-a21e-be6b437df72a"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MovieRooms");
        }
    }
}
