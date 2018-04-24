apt-get update \
    && apt-get install -y --no-install-recommends \
        libc6 \
        libcurl3 \
        libgcc1 \
        libgssapi-krb5-2 \
        libicu57 \
        liblttng-ust0 \
        libssl1.0.2 \
        libstdc++6 \
        libunwind8 \
        libuuid1 \
        zlib1g \
    && rm -rf /var/lib/apt/lists/*

curl -SL https://dotnetcli.blob.core.windows.net/dotnet/Sdk/2.1.105/dotnet-sdk-2.1.105-linux-x64.tar.gz --output dotnet.tar.gz \
    && echo "b5e71dee8720595b0eff7518cca49854ed183e7ca68b98e2ca0580be3f6893f25a1bb267367601f575529a0fd8c94bb379a1411564ed5beaa340a54f37a5e16a dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -zxf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz \
&& ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet