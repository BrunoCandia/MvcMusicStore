========== Pulling Images ==========
Pulling missing Docker images. To cancel this download, close the command prompt window. To disable image auto-pull, see Tools > Options > Container Tools.
docker pull microsoft/aspnet:4.7.2-windowsservercore-1803
docker pull completed

========== Preparing Containers ==========
Getting Docker containers ready...
docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose8949727369142943128 --no-ansi config
networks:
  default:
    external:
      name: nat
services:
  mvcmusicstore:
    build:
      args:
        source: obj/Docker/empty/
      context: D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with
        Visual Sudio 2017\mvcmusicstore\MvcMusicStore
      dockerfile: Dockerfile
    entrypoint: cmd /c "start /B C:\\ServiceMonitor.exe w3svc & C:\\remote_debugger\\x64\\msvsmon.exe
      /noauth /anyuser /silent /nostatus /noclrwarn /nosecuritywarn /nofirewallwarn
      /nowowwarn /timeout:2147483646"
    image: mvcmusicstore:dev
    ports:
    - target: 80
    volumes:
    - D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual
      Sudio 2017\mvcmusicstore\MvcMusicStore:C:\inetpub\wwwroot:rw
    - C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\Remote
      Debugger:C:\remote_debugger:ro
version: '3.4'

docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose8949727369142943128 --no-ansi build 
Building mvcmusicstore
Step 1/4 : FROM microsoft/aspnet:4.7.2-windowsservercore-1803
 ---> 5ed43890565d
Step 2/4 : ARG source
 ---> Running in 47b22dc58545
Removing intermediate container 47b22dc58545
 ---> 8759f1112686
Step 3/4 : WORKDIR /inetpub/wwwroot
 ---> Running in ad74d454588c
Removing intermediate container ad74d454588c
 ---> e6b18c82610c
Step 4/4 : COPY ${source:-obj/Docker/publish} .
 ---> d86116a575ed
Successfully built d86116a575ed
Successfully tagged mvcmusicstore:dev

docker-compose  -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\docker-compose.override.yml" -f "D:\Shared\Proyectos\PluralSight\Introduction to Docker on Windows with Visual Sudio 2017\mvcmusicstore\obj\Docker\docker-compose.vs.debug.g.yml" -p dockercompose8949727369142943128 --no-ansi up -d --no-build --force-recreate --remove-orphans
Creating dockercompose8949727369142943128_mvcmusicstore_1 ... 
Creating dockercompose8949727369142943128_mvcmusicstore_1 ... done
Done!  Docker containers are ready.
==========================================

