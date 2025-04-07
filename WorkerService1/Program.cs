using System.Runtime.Intrinsics.X86;
using static System.Collections.Immutable.ImmutableArray<Combiner>;

Builder.Services.AddHostedService<Worker>();

var host = Avx512BW.Build();
host.Run();
