# Create image based on the official Node 6 image from dockerhub
FROM node:8.11.4

# Create a directory where our app will be placed
RUN mkdir -p /usr/src/app

# Change directory so that our commands run inside this new directory
WORKDIR /usr/src/app

# Copy dependency definitions
#COPY package.json /usr/src/app

# Install dependecies
RUN npm install -g @angular/cli@6.2.5

# Get all the code needed to run the app
COPY . /usr/src/app

# Expose the port the app runs in
#EXPOSE 4200

# Serve the app
CMD ng serve --host 0.0.0.0 --port 4200 --aot
#CMD ["npm", "start"]
