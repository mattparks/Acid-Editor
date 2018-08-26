cd ../

mkdir Build\Debug\bin\Resources

mklink /J Build\Debug\bin\Resources\Engine Libraries\Acid\Resources
mklink /J Build\Debug\bin\Resources\Editor Resources
mklink /J Build\Release\bin\Resources\Engine Libraries\Acid\Resources
mklink /J Build\Release\bin\Resources\Editor Resources
mklink /J Build\RelWithDebInfo\bin\Resources\Engine Libraries\Acid\Resources
mklink /J Build\RelWithDebInfo\bin\Resources\Editor Resources

mklink /J Build\Sources\Resources\Engine Libraries\Acid\Resources
mklink /J Build\Sources\Resources\Editor Resources
