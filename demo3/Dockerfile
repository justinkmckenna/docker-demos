#Multi stage build

#First container has the stuff to build our app
FROM ubuntu:20.04 as build
RUN apt-get update && apt-get install -y build-essential
WORKDIR /app
COPY src/whalehello.c /app/
# -static means we don't need other stuff installed?
RUN gcc -o whalehello -static whalehello.c

#Second container only has our compiled app
# alpine linux is a super small container to run final containers, only 5mb in size
FROM alpine:3.15.0 as final
WORKDIR /app/
COPY --from=build /app/whalehello ./
ENTRYPOINT ["/app/whalehello"]