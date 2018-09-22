using System;
using Microsoft.EntityFrameworkCore;

namespace EfCoreTest
{
    public class TestContext : DbContext
    {
        public DbSet<RootEntity> RootEntities { get; set; }
        public DbSet<AEntity> AEntities { get; set; }
        public DbSet<BEntity> BEntities { get; set; }
        public DbSet<CEntity> CEntities { get; set; }
        public DbSet<DEntity> DEntities { get; set; }
        public DbSet<DEntity> EEntities { get; set; }
        public DbSet<FEntity> FEntities { get; set; }
        public DbSet<GEntity> GEntities { get; set; }
        public DbSet<HEntity> HEntities { get; set; }
        public DbSet<IEntity> IEntities { get; set; }
        public DbSet<JEntity> JEntities { get; set; }
        public DbSet<KEntity> KEntities { get; set; }
        public DbSet<LEntity> LEntities { get; set; }
        public DbSet<MEntity> MEntities { get; set; }
        public DbSet<NEntity> NEntities { get; set; }
        public DbSet<OEntity> OEntities { get; set; }
        public DbSet<PEntity> PEntities { get; set; }
        public DbSet<QEntity> QEntities { get; set; }
        public DbSet<REntity> REntities { get; set; }
        public DbSet<SEntity> SEntities { get; set; }
        public DbSet<TEntity> TEntities { get; set; }
        public DbSet<UEntity> UEntities { get; set; }
        public DbSet<VEntity> VEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
        }
    }

    public class RootEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Text5 { get; set; }
        public string Text6 { get; set; }
        public string Text7 { get; set; }
        public string Text8 { get; set; }
        public string Text9 { get; set; }
        public string Text10 { get; set; }
        public string Text11 { get; set; }
        public string Text12 { get; set; }
        public string Text13 { get; set; }
        public string Text14 { get; set; }
        public string Text15 { get; set; }
        public string Text16 { get; set; }
        public string Text17 { get; set; }
        public string Text18 { get; set; }
        public string Text19 { get; set; }
        public string Text20 { get; set; }
        public string Text21 { get; set; }
        public string Text22 { get; set; }
        public string Text23 { get; set; }
        public string Text24 { get; set; }
        public string Text25 { get; set; }
        public string Text26 { get; set; }
        public string Text27 { get; set; }
        public string Text28 { get; set; }
        public string Text29 { get; set; }
        public string Text30 { get; set; }
        public string Text31 { get; set; }
        public string Text32 { get; set; }
        public string Text33 { get; set; }
        public string Text34 { get; set; }
        public string Text35 { get; set; }
        public string Text36 { get; set; }
        public string Text37 { get; set; }
        public string Text38 { get; set; }
        public string Text39 { get; set; }
        public string Text40 { get; set; }
        public string Text41 { get; set; }
        public string Text42 { get; set; }
        public string Text43 { get; set; }
        public string Text44 { get; set; }
        public string Text45 { get; set; }
        public string Text46 { get; set; }
        public string Text47 { get; set; }
        public string Text48 { get; set; }
        public string Text49 { get; set; }
        public string Text50 { get; set; }
        public long AEntityId { get; set; }
        public long AAEntityId { get; set; }
        public long AAAEntityId { get; set; }
        public long AAAAEntityId { get; set; }
        public long AAAAAEntityId { get; set; }
        public long BEntityId { get; set; }
        public long CEntityId { get; set; }
        public long DEntityId { get; set; }
        public long EEntityId { get; set; }
        public long FEntityId { get; set; }
        public long GEntityId { get; set; }
        public long HEntityId { get; set; }
        public long IEntityId { get; set; }
        public long JEntityId { get; set; }
        public long KEntityId { get; set; }
        public long LEntityId { get; set; }
        public long MEntityId { get; set; }
        public long NEntityId { get; set; }
        public long OEntityId { get; set; }
        public long PEntityId { get; set; }
        public long QEntityId { get; set; }
        public long REntityId { get; set; }
        public long SEntityId { get; set; }
        public long TEntityId { get; set; }
        public long UEntityId { get; set; }
        public long VEntityId { get; set; }
    }

    public class AEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class BEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class CEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class DEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class EEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class FEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class GEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class HEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class JEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class KEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class LEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class MEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class NEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class OEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class PEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class QEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class REntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class SEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class TEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class UEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class VEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}