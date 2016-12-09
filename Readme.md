This is the contracts package for [StatsN](https://github.com/TryStatsN/StatsN) and its [sync counterpart](https://github.com/TryStatsN/StatsN.NoAsync). 

This package contains the basic interfaces/Contracts that make up StatsN.


there are 3 interfaces. `IStatsdSync` which contains the contract for making sync calls to log stats, `IStatsdAsync` which inherits from `IStatsdSync` and contains the interfaces for any async calls. There is also `IStatsd` which inherits from both, and is just a shorthand for `IStatsdAsync`.



## Which interface should I use?

Try to use `IStatsd` and use the async functions. Only use `IStatsdSync` if you plan on using the [completely no async client](https://github.com/TryStatsN/StatsN.NoAsync).