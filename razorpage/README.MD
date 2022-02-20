

dotnet aspnet-codegenerator razorpage -m Driver -dc driverapp.Data.razorpageContext -udl -outDir Pages\Drivers --referenceScriptLibraries -sqlite

dotnet aspnet-codegenerator razorpage -m Driver -dc customerapp.Data.razorpageContext -udl -outDir Pages\Customers --referenceScriptLibraries -sqlite