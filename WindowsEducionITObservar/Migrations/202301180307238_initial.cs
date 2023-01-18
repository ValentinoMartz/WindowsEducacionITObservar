namespace WindowsEducionITObservar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carreras",
                c => new
                    {
                        IdCarrera = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdCarrera);
            
            CreateTable(
                "dbo.Plans",
                c => new
                    {
                        IdPlan = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        IdCarrera = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPlan)
                .ForeignKey("dbo.Carreras", t => t.IdCarrera, cascadeDelete: true)
                .Index(t => t.IdCarrera);
            
            CreateTable(
                "dbo.Planillas",
                c => new
                    {
                        IdPlanilla = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        IdProfesor = c.Int(nullable: false),
                        IdMateria = c.Int(nullable: false),
                        IdCarrra = c.Int(nullable: false),
                        IdCurso = c.Int(nullable: false),
                        Carrera_IdCarrera = c.Int(),
                    })
                .PrimaryKey(t => t.IdPlanilla)
                .ForeignKey("dbo.Carreras", t => t.Carrera_IdCarrera)
                .ForeignKey("dbo.Cursoes", t => t.IdCurso, cascadeDelete: true)
                .ForeignKey("dbo.Profesors", t => t.IdProfesor, cascadeDelete: true)
                .ForeignKey("dbo.Materias", t => t.IdMateria, cascadeDelete: true)
                .Index(t => t.IdProfesor)
                .Index(t => t.IdMateria)
                .Index(t => t.IdCurso)
                .Index(t => t.Carrera_IdCarrera);
            
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        IdCurso = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdCurso);
            
            CreateTable(
                "dbo.Detalles",
                c => new
                    {
                        IdDetalle = c.Int(nullable: false, identity: true),
                        IdPlanilla = c.Int(nullable: false),
                        IdEstado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalle)
                .ForeignKey("dbo.Estadoes", t => t.IdEstado, cascadeDelete: true)
                .ForeignKey("dbo.Planillas", t => t.IdPlanilla, cascadeDelete: true)
                .Index(t => t.IdPlanilla)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        IdEstado = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdEstado);
            
            CreateTable(
                "dbo.Evaluacions",
                c => new
                    {
                        IdEvaluacion = c.Int(nullable: false, identity: true),
                        Nota = c.Int(nullable: false),
                        IdEstudiante = c.Int(nullable: false),
                        IdTipo = c.Int(nullable: false),
                        IdDetalle = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEvaluacion)
                .ForeignKey("dbo.Detalles", t => t.IdDetalle, cascadeDelete: true)
                .ForeignKey("dbo.Estudiantes", t => t.IdEstudiante, cascadeDelete: true)
                .ForeignKey("dbo.Tipoes", t => t.IdTipo, cascadeDelete: true)
                .Index(t => t.IdEstudiante)
                .Index(t => t.IdTipo)
                .Index(t => t.IdDetalle);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        IdEstudiante = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Telefono = c.String(),
                        Calle = c.String(),
                        Numero = c.Int(nullable: false),
                        IdLocalidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEstudiante)
                .ForeignKey("dbo.Localidads", t => t.IdLocalidad, cascadeDelete: true)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Localidads",
                c => new
                    {
                        IdLocalidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        IdProfesor = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        IdLocalidad = c.Int(),
                    })
                .PrimaryKey(t => t.IdProfesor)
                .ForeignKey("dbo.Localidads", t => t.IdLocalidad)
                .Index(t => t.IdLocalidad);
            
            CreateTable(
                "dbo.Tipoes",
                c => new
                    {
                        IdTipo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdTipo);
            
            CreateTable(
                "dbo.Materias",
                c => new
                    {
                        IdMateria = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.IdMateria);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Planillas", "IdMateria", "dbo.Materias");
            DropForeignKey("dbo.Detalles", "IdPlanilla", "dbo.Planillas");
            DropForeignKey("dbo.Evaluacions", "IdTipo", "dbo.Tipoes");
            DropForeignKey("dbo.Planillas", "IdProfesor", "dbo.Profesors");
            DropForeignKey("dbo.Profesors", "IdLocalidad", "dbo.Localidads");
            DropForeignKey("dbo.Estudiantes", "IdLocalidad", "dbo.Localidads");
            DropForeignKey("dbo.Evaluacions", "IdEstudiante", "dbo.Estudiantes");
            DropForeignKey("dbo.Evaluacions", "IdDetalle", "dbo.Detalles");
            DropForeignKey("dbo.Detalles", "IdEstado", "dbo.Estadoes");
            DropForeignKey("dbo.Planillas", "IdCurso", "dbo.Cursoes");
            DropForeignKey("dbo.Planillas", "Carrera_IdCarrera", "dbo.Carreras");
            DropForeignKey("dbo.Plans", "IdCarrera", "dbo.Carreras");
            DropIndex("dbo.Profesors", new[] { "IdLocalidad" });
            DropIndex("dbo.Estudiantes", new[] { "IdLocalidad" });
            DropIndex("dbo.Evaluacions", new[] { "IdDetalle" });
            DropIndex("dbo.Evaluacions", new[] { "IdTipo" });
            DropIndex("dbo.Evaluacions", new[] { "IdEstudiante" });
            DropIndex("dbo.Detalles", new[] { "IdEstado" });
            DropIndex("dbo.Detalles", new[] { "IdPlanilla" });
            DropIndex("dbo.Planillas", new[] { "Carrera_IdCarrera" });
            DropIndex("dbo.Planillas", new[] { "IdCurso" });
            DropIndex("dbo.Planillas", new[] { "IdMateria" });
            DropIndex("dbo.Planillas", new[] { "IdProfesor" });
            DropIndex("dbo.Plans", new[] { "IdCarrera" });
            DropTable("dbo.Materias");
            DropTable("dbo.Tipoes");
            DropTable("dbo.Profesors");
            DropTable("dbo.Localidads");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Evaluacions");
            DropTable("dbo.Estadoes");
            DropTable("dbo.Detalles");
            DropTable("dbo.Cursoes");
            DropTable("dbo.Planillas");
            DropTable("dbo.Plans");
            DropTable("dbo.Carreras");
        }
    }
}
