#Multi stage build

#First container has the stuff to build our app
FROM ubuntu:20.04 as build
RUN apt-get update && apt-get install -y build-essential
WORKDIR /app
COPY src/whalehello.c /app/
# -static means we don't need other stuff installed?
RUN gcc -o whalehello -static whalehello.c

#Second container only has our compiled app
# scratch means we already have what we need, no need to download anything #would usually use alpine or nginx 
FROM scratch as final
WORKDIR /app/
COPY --from=build /app/whalehello ./
ENTRYPOINT ["/app/whalehello"]