using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace DotnetBoilerplate.Infrastructure.RepositoriesBase.EntityFrameworkCore
{
    public class GuidValueGenerator : ValueGenerator
    {
        public override bool GeneratesTemporaryValues => false;

        protected override object NextValue([NotNull] EntityEntry entry)
        {
            return Guid.NewGuid();
        }

        protected override ValueTask<object> NextValueAsync(EntityEntry entry, CancellationToken cancellationToken = default)
        {
            return new ValueTask<object>(Guid.NewGuid());
        }
    }
}
