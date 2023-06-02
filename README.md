# Adding apps & libs

## Orders

### Backend

#### Generate orders API

`npx nx g @nx-dotnet/core:app orders/api --template webapi --test-template xunit --language C# --skipSwaggerLib true --tags orders --no-interactive`

#### Generate libraries for orders API

`npx nx g @nx-dotnet/core:lib orders/domain --template classlib --test-template none --language C# --tags orders,shared --no-interactive`

`npx nx g @nx-dotnet/core:lib orders/infrastructure --template classlib --test-template none --language C# --tags orders --no-interactive`

`npx nx g @nx-dotnet/core:lib orders/use-cases --template classlib --test-template none --language C# --tags orders --no-interactive`

#### Generate swagger libs for orders API

`npx nx g @nx-dotnet/core:add-swagger-target --project=orders-api --codegenProject=orders-api-types --swaggerProject=orders-api-swagger --useNxPluginOpenAPI false`

#### Generate references for orders

`npx nx g @nx-dotnet/core:project-reference orders-infrastructure --reference=orders-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-use-cases --reference=orders-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-use-cases --reference=orders-infrastructure --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-api --reference=orders-use-cases --no-interactive`

### Frontend

#### Generate orders components libraries

`npx nx g @nx-dotnet/core:lib orders/components --template razorclasslib --test-template none --language C# --tags components --no-interactive`

## Products

### Backend

#### Generate products API

`npx nx g @nx-dotnet/core:app products/api --template webapi --test-template xunit --language C# --tags products --skipSwaggerLib true --no-interactive`

#### Generate libraries for products API

`npx nx g @nx-dotnet/core:lib products/domain --template classlib --test-template none --language C# --tags products,shared --no-interactive`

`npx nx g @nx-dotnet/core:lib products/infrastructure --template classlib --test-template none --language C# --tags products --no-interactive`

`npx nx g @nx-dotnet/core:lib products/use-cases --template classlib --test-template none --language C# --tags products --no-interactive`

#### Generate swagger libs for products API

`npx nx g @nx-dotnet/core:add-swagger-target --project=products-api --codegenProject=products-api-types --swaggerProject=products-api-swagger --useNxPluginOpenAPI false`

#### Generate references for products

`npx nx g @nx-dotnet/core:project-reference products-infrastructure --reference=products-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference products-use-cases --reference=products-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference products-use-cases --reference=products-infrastructure --no-interactive`

`npx nx g @nx-dotnet/core:project-reference products-api --reference=products-use-cases --no-interactive`

### Frontend

#### Generate products components libraries

`npx nx g @nx-dotnet/core:lib products/components --template razorclasslib --test-template none --language C# --tags components --no-interactive`

## Sites

`npx nx g @nx-dotnet/core:app sites/admin --template blazorwasm --test-template xunit --language C# --tags sites --no-interactive`

`npx nx g @nx-dotnet/core:app sites/store --template blazorwasm --test-template xunit --language C# --tags sites --no-interactive`

#### Components references

`npx nx g @nx-dotnet/core:project-reference sites-admin --reference=orders-components --no-interactive`

`npx nx g @nx-dotnet/core:project-reference sites-store --reference=orders-components --no-interactive`

`npx nx g @nx-dotnet/core:project-reference sites-admin --reference=products-components --no-interactive`

`npx nx g @nx-dotnet/core:project-reference sites-store --reference=products-components --no-interactive`

## Shared

`npx nx g @nx-dotnet/core:lib shared/api-utils --template classlib --test-template none --language C# --tags shared --no-interactive`

`npx nx g @nx-dotnet/core:lib shared/infrastructure-utils --template classlib --test-template none --language C# --tags shared --no-interactive`

`npx nx g @nx-dotnet/core:lib shared/framework --template classlib --test-template none --language C# --tags shared --no-interactive`

#### References

`npx nx g @nx-dotnet/core:project-reference shared-infrastructure-utils --reference=shared-framework --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-domain --reference=shared-framework --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-infrastructure --reference=shared-framework --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-use-cases --reference=shared-framework --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-infrastructure --reference=shared-infrastructure-utils  --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-use-cases --reference=shared-infrastructure-utils  --no-interactive`
