FROM ubuntu:20.04
RUN apt-get update
RUN apt-get install -y build-essential
WORKDIR /app
COPY src/whalehello.c /app/
RUN gcc -o whalehello whalehello.c
ENTRYPOINT ["/app/whalehello"]