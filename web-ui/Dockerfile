FROM node as builder

WORKDIR /app
COPY . .
RUN npm ci && npm run build

FROM nginx as server
ENV NODE_ENV ${ENVIRONMENT}
COPY --from=builder /app/build /usr/share/nginx/html
RUN echo "\
server {\n\
  listen 80;\n\
  \n\
  location / {\n\
    root /usr/share/nginx/html/;\n\
    include /etc/nginx/mime.types;\n\
    try_files $uri $uri/ /index.html;\n\
  }\n\
}" > /etc/nginx/conf.d/default.conf

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]