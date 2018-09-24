using System;
using System.Linq;
using Bogus;
using Newtonsoft.Json;

namespace EfCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var dbContext = new TestContext())
                {
                    dbContext.Database.EnsureCreated();

                    var AEntities = new Faker<AEntity>()
                                    .RuleFor(c => c.Name, f => f.Random.String(10))
                                    .Generate(10);

                    dbContext.AddRange(AEntities);
                    dbContext.SaveChanges();

                    dbContext.AddRange(new Faker<RootEntity>()
                                    .StrictMode(false)
                                    .RuleFor(c => c.Name, f => f.Random.String(10))
                                    .RuleFor(c => c.AEntityId, f => f.PickRandom(AEntities).Id)
                                    .RuleFor(c => c.AAEntityId, f => f.PickRandom(AEntities).Id)
                                    .RuleFor(c => c.AAAEntityId, f => f.PickRandom(AEntities).Id)
                                    .RuleFor(c => c.AAAAEntityId, f => f.PickRandom(AEntities).Id)
                                    .RuleFor(c => c.AAAAAEntityId, f => f.PickRandom(AEntities).Id)
                                    .RuleFor(c => c.Text1, f => f.Random.String(10))
                                    .RuleFor(c => c.Text2, f => f.Random.String(10))
                                    .RuleFor(c => c.Text3, f => f.Random.String(10))
                                    .RuleFor(c => c.Text4, f => f.Random.String(10))
                                    .RuleFor(c => c.Text5, f => f.Random.String(10))
                                    .RuleFor(c => c.Text6, f => f.Random.String(10))
                                    .RuleFor(c => c.Text7, f => f.Random.String(10))
                                    .RuleFor(c => c.Text8, f => f.Random.String(10))
                                    .RuleFor(c => c.Text9, f => f.Random.String(10))
                                    .RuleFor(c => c.Text10, f => f.Random.String(10))
                                    .RuleFor(c => c.Text11, f => f.Random.String(10))
                                    .RuleFor(c => c.Text12, f => f.Random.String(10))
                                    .RuleFor(c => c.Text13, f => f.Random.String(10))
                                    .RuleFor(c => c.Text14, f => f.Random.String(10))
                                    .RuleFor(c => c.Text15, f => f.Random.String(10))
                                    .RuleFor(c => c.Text16, f => f.Random.String(10))
                                    .RuleFor(c => c.Text17, f => f.Random.String(10))
                                    .RuleFor(c => c.Text18, f => f.Random.String(10))
                                    .RuleFor(c => c.Text19, f => f.Random.String(10))
                                    .RuleFor(c => c.Text20, f => f.Random.String(10))
                                    .RuleFor(c => c.Text21, f => f.Random.String(10))
                                    .RuleFor(c => c.Text22, f => f.Random.String(10))
                                    .RuleFor(c => c.Text23, f => f.Random.String(10))
                                    .RuleFor(c => c.Text24, f => f.Random.String(10))
                                    .RuleFor(c => c.Text25, f => f.Random.String(10))
                                    .RuleFor(c => c.Text26, f => f.Random.String(10))
                                    .RuleFor(c => c.Text27, f => f.Random.String(10))
                                    .RuleFor(c => c.Text28, f => f.Random.String(10))
                                    .RuleFor(c => c.Text29, f => f.Random.String(10))
                                    .RuleFor(c => c.Text30, f => f.Random.String(10))
                                    .Generate(10));
                    dbContext.SaveChanges();

                    var data1 = (from header in dbContext.RootEntities
                                join a in dbContext.AEntities on header.AEntityId equals a.Id
                                join aa in dbContext.AEntities on header.AAEntityId equals aa.Id
                                join aaa in dbContext.AEntities on header.AAAEntityId equals aaa.Id
                                join aaaa in dbContext.AEntities on header.AAAAEntityId equals aaaa.Id
                                join aaaaa in dbContext.AEntities on header.AAAAAEntityId equals aaaaa.Id
                                join b in dbContext.BEntities on header.BEntityId equals b.Id
                                join c in dbContext.CEntities on header.CEntityId equals c.Id
                                join d in dbContext.DEntities on header.DEntityId equals d.Id
                                join e in dbContext.EEntities on header.EEntityId equals e.Id
                                join f in dbContext.FEntities on header.FEntityId equals f.Id
                                join g in dbContext.GEntities on header.GEntityId equals g.Id
                                join h in dbContext.HEntities on header.HEntityId equals h.Id
                                join i in dbContext.IEntities on header.IEntityId equals i.Id
                                join j in dbContext.JEntities on header.JEntityId equals j.Id
                                join k in dbContext.KEntities on header.KEntityId equals k.Id
                                join l in dbContext.LEntities on header.LEntityId equals l.Id
                                join m in dbContext.MEntities on header.MEntityId equals m.Id
                                join n in dbContext.NEntities on header.NEntityId equals n.Id
                                join o in dbContext.OEntities on header.OEntityId equals o.Id
                                join p in dbContext.PEntities on header.PEntityId equals p.Id
                                join q in dbContext.QEntities on header.QEntityId equals q.Id
                                join r in dbContext.REntities on header.REntityId equals r.Id
                                join s in dbContext.SEntities on header.SEntityId equals s.Id
                                join t in dbContext.TEntities on header.TEntityId equals t.Id
                                join u in dbContext.UEntities on header.UEntityId equals u.Id
                                join v in dbContext.VEntities on header.VEntityId equals v.Id
                                select new
                                {
                                    header.Id,
                                    header.Name,
                                    header.AEntityId,
                                    header.AAEntityId,
                                    header.AAAEntityId,
                                    header.AAAAEntityId,
                                    header.AAAAAEntityId,
                                    header.BEntityId,
                                    header.CEntityId,
                                    header.DEntityId,
                                    header.EEntityId,
                                    header.FEntityId,
                                    header.GEntityId,
                                    header.HEntityId,
                                    header.IEntityId,
                                    header.JEntityId,
                                    header.KEntityId,
                                    header.LEntityId,
                                    header.MEntityId,
                                    header.NEntityId,
                                    header.OEntityId,
                                    header.PEntityId,
                                    header.QEntityId,
                                    header.REntityId,
                                    header.SEntityId,
                                    header.TEntityId,
                                    header.UEntityId,
                                    header.VEntityId,
                                    AName = a.Name,
                                    AAName = aa.Name,
                                    AAAName = aaa.Name,
                                    AAAAName = aaaa.Name,
                                    AAAAAName  = aaaaa.Name,
                                    BName = b.Name,
                                    CName = c.Name,
                                    DName = d.Name,
                                    EName = e.Name,
                                    FName = f.Name,
                                    GName = g.Name,
                                    HName = h.Name,
                                    IName = i.Name,
                                    JName = j.Name,
                                    KName = k.Name,
                                    LName = l.Name,
                                    MName = m.Name,
                                    NName = n.Name,
                                    OName = o.Name,
                                    PName = p.Name,
                                    QName = q.Name,
                                    RName = r.Name,
                                    SName = s.Name,
                                    TName = t.Name,
                                    UName = u.Name,
                                    VName = v.Name,
                                    header.Text1,
                                    header.Text2,
                                    header.Text3,
                                    header.Text4,
                                    header.Text5,
                                    header.Text6,
                                    header.Text7,
                                    header.Text8,
                                    header.Text9,
                                    header.Text10,
                                    header.Text11,
                                    header.Text12,
                                    header.Text13,
                                    header.Text14,
                                    header.Text15,
                                    header.Text16,
                                    header.Text17,
                                    header.Text18,
                                    header.Text19,
                                    header.Text20,
                                    header.Text21,
                                    header.Text22,
                                    header.Text23,
                                    header.Text24,
                                    header.Text25,
                                    header.Text26,
                                    header.Text27,
                                    header.Text28,
                                    header.Text29,
                                    header.Text30,
                                    header.Text31,
                                    header.Text32,
                                    header.Text33,
                                    header.Text34,
                                    header.Text35,
                                    header.Text36,
                                    header.Text37,
                                    header.Text38,
                                    header.Text39,
                                    header.Text40,
                                    header.Text41,
                                    header.Text42,
                                    header.Text43,
                                    header.Text44,
                                    header.Text45,
                                    header.Text46,
                                    header.Text47,
                                    header.Text48,
                                    header.Text49,
                                    header.Text50,
                                }).FirstOrDefault();

                    Console.WriteLine("Finished, test query inner join");
                    Console.WriteLine(JsonConvert.SerializeObject(data1, Formatting.Indented));

                    var data2 = (from header in dbContext.RootEntities
                                 join a in dbContext.AEntities on header.AEntityId equals a.Id into tempA
                                 from a in tempA.DefaultIfEmpty()
                                 join aa in dbContext.AEntities on header.AAEntityId equals aa.Id into tempAA
                                 from aa in tempAA.DefaultIfEmpty()
                                 join b in dbContext.BEntities on header.AEntityId equals b.Id into tempB
                                 from b in tempB.DefaultIfEmpty()
                                 join c in dbContext.CEntities on header.BEntityId equals c.Id into tempC
                                 from c in tempC.DefaultIfEmpty()
                                 join d in dbContext.DEntities on header.CEntityId equals d.Id into tempD
                                 from d in tempD.DefaultIfEmpty()
                                 join e in dbContext.EEntities on header.EEntityId equals e.Id into tempE
                                 from e in tempE.DefaultIfEmpty()
                                 join f in dbContext.FEntities on header.FEntityId equals f.Id into tempF
                                 from f in tempF.DefaultIfEmpty()
                                 join g in dbContext.GEntities on header.GEntityId equals g.Id into tempG
                                 from g in tempG.DefaultIfEmpty()
                                 join h in dbContext.HEntities on header.HEntityId equals h.Id into tempH
                                 from h in tempH.DefaultIfEmpty()
                                 join i in dbContext.IEntities on header.IEntityId equals i.Id into tempI
                                 from i in tempI.DefaultIfEmpty()
                                 join j in dbContext.JEntities on header.JEntityId equals j.Id into tempJ
                                 from j in tempJ.DefaultIfEmpty()
                                 join k in dbContext.KEntities on header.KEntityId equals k.Id into tempK
                                 from k in tempK.DefaultIfEmpty()
                                 join l in dbContext.LEntities on header.LEntityId equals l.Id into tempL
                                 from l in tempL.DefaultIfEmpty()
                                 join m in dbContext.MEntities on header.MEntityId equals m.Id into tempM
                                 from m in tempM.DefaultIfEmpty()
                                 join n in dbContext.NEntities on header.NEntityId equals n.Id into tempN
                                 from n in tempN.DefaultIfEmpty()
                                 join o in dbContext.OEntities on header.OEntityId equals o.Id into tempO
                                 from o in tempO.DefaultIfEmpty()
                                 join p in dbContext.PEntities on header.PEntityId equals p.Id into tempP
                                 from p in tempP.DefaultIfEmpty()
                                 join q in dbContext.QEntities on header.QEntityId equals q.Id into tempQ
                                 from q in tempQ.DefaultIfEmpty()
                                 join r in dbContext.REntities on header.REntityId equals r.Id into tempR
                                 from r in tempR.DefaultIfEmpty()
                                 join s in dbContext.SEntities on header.SEntityId equals s.Id into tempS
                                 from s in tempS.DefaultIfEmpty()
                                 join t in dbContext.TEntities on header.TEntityId equals t.Id into tempT
                                 from t in tempT.DefaultIfEmpty()
                                 join u in dbContext.UEntities on header.UEntityId equals u.Id into tempU
                                 from u in tempU.DefaultIfEmpty()
                                 join v in dbContext.VEntities on header.VEntityId equals v.Id into tempV
                                 from v in tempV.DefaultIfEmpty()
                                 select new
                                 {
                                     header.Id,
                                     header.Name,
                                     header.AEntityId,
                                     header.AAEntityId,
                                     header.AAAEntityId,
                                     header.AAAAEntityId,
                                     header.AAAAAEntityId,
                                     header.BEntityId,
                                     header.CEntityId,
                                     header.DEntityId,
                                     header.EEntityId,
                                     header.FEntityId,
                                     header.GEntityId,
                                     header.HEntityId,
                                     header.IEntityId,
                                     header.JEntityId,
                                     header.KEntityId,
                                     header.LEntityId,
                                     header.MEntityId,
                                     header.NEntityId,
                                     header.OEntityId,
                                     header.PEntityId,
                                     header.QEntityId,
                                     header.REntityId,
                                     header.SEntityId,
                                     header.TEntityId,
                                     header.UEntityId,
                                     header.VEntityId,
                                     AName = a.Name,
                                     AAName = aa.Name,
                                     BName = b.Name,
                                     CName = c.Name,
                                     DName = d.Name,
                                     EName = e.Name,
                                     FName = f.Name,
                                     GName = g.Name,
                                     HName = h.Name,
                                     IName = i.Name,
                                     JName = j.Name,
                                     KName = k.Name,
                                     LName = l.Name,
                                     MName = m.Name,
                                     NName = n.Name,
                                     OName = o.Name,
                                     PName = p.Name,
                                     QName = q.Name,
                                     RName = r.Name,
                                     SName = s.Name,
                                     TName = t.Name,
                                     UName = u.Name,
                                     VName = v.Name,
                                     header.Text1,
                                     header.Text2,
                                     header.Text3,
                                     header.Text4,
                                     header.Text5,
                                     header.Text6,
                                     header.Text7,
                                     header.Text8,
                                     header.Text9,
                                     header.Text10,
                                     header.Text11,
                                     header.Text12,
                                     header.Text13,
                                     header.Text14,
                                     header.Text15,
                                     header.Text16,
                                     header.Text17,
                                     header.Text18,
                                     header.Text19,
                                     header.Text20,
                                     header.Text21,
                                     header.Text22,
                                     header.Text23,
                                     header.Text24,
                                     header.Text25,
                                     header.Text26,
                                     header.Text27,
                                     header.Text28,
                                     header.Text29,
                                     header.Text30,
                                     header.Text31,
                                     header.Text32,
                                     header.Text33,
                                     header.Text34,
                                     header.Text35,
                                     header.Text36,
                                     header.Text37,
                                     header.Text38,
                                     header.Text39,
                                     header.Text40,
                                     header.Text41,
                                     header.Text42,
                                     header.Text43,
                                     header.Text44,
                                     header.Text45,
                                     header.Text46,
                                     header.Text47,
                                     header.Text48,
                                     header.Text49,
                                     header.Text50,
                                 }).FirstOrDefault();

                    Console.WriteLine("Finished, test query left join");
                    Console.WriteLine(JsonConvert.SerializeObject(data2, Formatting.Indented));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
