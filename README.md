# Adding apps & libs

## Orders

### Backend

#### Generate orders API

`npx nx g @nx-dotnet/core:app orders-api --template webapi --test-template xunit --language C# --tags orders --no-interactive`

#### Generate libraries for orders API

`npx nx g @nx-dotnet/core:lib orders/domain --template classlib --test-template none --language C# --tags orders --no-interactive`

`npx nx g @nx-dotnet/core:lib orders/infrastructure --template classlib --test-template none --language C# --tags orders --no-interactive`

`npx nx g @nx-dotnet/core:lib orders/use-cases --template classlib --test-template none --language C# --tags orders --no-interactive`

#### Generate swagger libs for orders API

`npx nx g @nx-dotnet/core:add-swagger-target --project=orders-api --codegenProject=orders-api-types --swaggerProject=orders-api-swagger --useNxPluginOpenAPI false`

#### Generate references for orders

`npx nx g @nx-dotnet/core:project-reference orders-infrastructure --reference=orders-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-use-cases --reference=orders-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-use-cases --reference=orders-infrastructure --no-interactive`

`npx nx g @nx-dotnet/core:project-reference orders-api --reference=orders-use-cases --no-interactive`

<!-- ### Frontend -->

## Products

### Backend

#### Generate products API

`npx nx g @nx-dotnet/core:app products-api --template webapi --test-template xunit --language C# --tags products --no-interactive`

#### Generate libraries for products API

`npx nx g @nx-dotnet/core:lib products/domain --template classlib --test-template none --language C# --tags products --no-interactive`

`npx nx g @nx-dotnet/core:lib products/infrastructure --template classlib --test-template none --language C# --tags products --no-interactive`

`npx nx g @nx-dotnet/core:lib products/use-cases --template classlib --test-template none --language C# --tags products --no-interactive`

#### Generate swagger libs for products API

`npx nx g @nx-dotnet/core:add-swagger-target --project=products-api --codegenProject=products-api-types --swaggerProject=products-api-swagger --useNxPluginOpenAPI false`

#### Generate references for products

`npx nx g @nx-dotnet/core:project-reference products-infrastructure --reference=products-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference products-use-cases --reference=products-domain --no-interactive`

`npx nx g @nx-dotnet/core:project-reference products-use-cases --reference=products-infrastructure --no-interactive`

`npx nx g @nx-dotnet/core:project-reference products-api --reference=products-use-cases --no-interactive`

<!-- ### Frontend -->